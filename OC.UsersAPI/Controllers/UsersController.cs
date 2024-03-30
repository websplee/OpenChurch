using AutoMapper;
using CrystalBLCore.BusinessServices;
using CrystalBLCore.BusinessServices.Interfaces;
using CrystalBLCore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using OC.Data.UnitOfWork.Interfaces;
using OC.Domain.Models;
using OC.Domain.Models.Users;
using OC.Domain.ViewModels.Users;
using OC.UsersAPI.Globals;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace OC.UsersAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly string _currentUserId;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private IUnitOfWork<Module> _module;
        private readonly IMapper _mapper;
        private readonly AppSettings _appSettings;
        private IEmailService _emailService;
        private bool IsAgent = false;
        private IConfiguration _configuration;


        // Constructor
        public UsersController(IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager, IUnitOfWork<Module> module, ILogger<UsersController> logger,
            IOptions<AppSettings> appSettings, IEmailService emailService, IConfiguration configuration)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _module = module;
            _logger = logger;
            _appSettings = appSettings.Value;
            _emailService = emailService;
            _currentUserId = UserService.CurrentUserId();
            _configuration = configuration;
        }

        /// <summary>
        /// Authenticate a user by passing login object
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Token with user claims</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] LoginInputModel model)
        {
            string token = null;

            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);

                if (user == null)
                {
                    return BadRequest("Invalid username or password");
                }

                if (!user.IsActive.Value)
                    return BadRequest("Your account is deactivated");

                if (user.IsFirstLogin.Value)
                    return BadRequest("Your kindly set your password first before you can log in.");

                if (user != null && !await _userManager.IsEmailConfirmedAsync(user))
                {
                    ModelState.AddModelError(string.Empty, "You must have a confirmed email to log in.");
                    return BadRequest("You must have a confirmed email to log in.");
                }

                var result = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberLogin.Value, lockoutOnFailure: true);
                if (result.Succeeded)
                {
                    var claims = await GenerateClaimsAsync(user);
                    token = GenerateToken(claims);

                    // token = await _userManager.GenerateUserTokenAsync(user, "Default", _userManager.Options.Tokens.AuthenticatorTokenProvider);
                    // Use token here
                    return Ok(new { Token = token });
                }
                if (result.RequiresTwoFactor)
                {
                    throw new NotImplementedException("2FA Not Implemented");
                    // return RedirectToAction(nameof(LoginWith2fa), new { returnUrl, model.RememberMe });
                }
                if (result.IsLockedOut)
                {
                    return Unauthorized("Your account is locked out");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return BadRequest("Invalid login attempt." + result.ToString());
                }
            }

            // If we got this far, something failed, redisplay form
            return BadRequest(model);
        }

        /// <summary>
        /// Register a user in the system.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(User))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = _mapper.Map<User>(model);

            user.IsActive = true;
            IdentityResult? result = null;

            if (model.Password == null) // If no password is supplied
            {
                user.IsFirstLogin = true;
                result = await _userManager.CreateAsync(user);
            }
            else // password is supplied
                result = await _userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }

            // Register Roles
            // await _userManager.AddToRoleAsync(user, "User");

            if (model.Roles != null)
                foreach (var role in model.Roles)
                {
                    await _userManager.AddToRoleAsync(user, role);
                }

            // Upload user image and update the user PictureUrl
            user.PictureUrl = user.PictureUrl != "" ? await UploadConvertBase64ImageToFileImage(user, "profile") : "";

            // Update the user
            await _userManager.UpdateAsync(user);

            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            // var confirmationLink = Url.Action(nameof(ConfirmEmail), "Users", new { token, email = user.Email }, Request.Scheme);
            // var confirmationLink = Url.Action("auth", "activate-email", new { token, email = user.Email }, Request.Scheme);           
            var basePath = _configuration["EmailConfiguration:BaseUrl"] + _configuration["EmailConfiguration:EmailConfirmationUrl"];

            string activationUrl = $"{basePath}?token={token}&email={user.Email}";

            string content = $"<h3>Your account with this user name has been successfully created.</h3> {model.Email} " +
                $"<p><em>DO NOT SHARE THESE CREDENTIALS WITH ANYONE.</em>" +
                $"<p>Kindly click on this link to activate your email account within 2 hours</p>" +
                $"<a href=\"{activationUrl}\" style=\"background-color: #007BFF; color: #fff; padding: 10px 20px; text-decoration: none; border-radius: 5px;\">Case Details</a>" +
                $"<p>Remember you will not be able to access your account until you activate it.</p>";

            var mail = PrepareEmail(new List<EmailAddress>() { new EmailAddress() { Name = "RIMSMailer", Address = "credentials@mcdss.gov.zm" } },
                new List<EmailAddress>() { new EmailAddress() { Name = user.Email, Address = user.Email } },
                "New Credentials", content);

            _emailService.Send(mail); // This process can take some time so sometimes no need to await

            return CreatedAtAction("Register", new { id = user.Id }, await GetById(user.Id));
        }

        /// <summary>
        /// Resets password for a user
        /// </summary>
        /// <param name="resetPasswordModel"></param>
        /// <returns></returns>
        [HttpPost("resetpassword")]
        //[ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordViewModel resetPasswordModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(resetPasswordModel);

            var user = await _userManager.FindByEmailAsync(resetPasswordModel.Email);
            if (user == null)
                BadRequest("Email did not bring up an valid account");

            var resetPassResult = await _userManager.ResetPasswordAsync(user, resetPasswordModel.Token, resetPasswordModel.Password);

            if (!resetPassResult.Succeeded)
            {
                foreach (var error in resetPassResult.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }

                return BadRequest(ModelState);
            }

            return Ok("Password successfully reset");
        }


        /// <summary>
        /// This is used as a self service link for someone to reset their password
        /// </summary>
        /// <param name="forgotPasswordViewModel"></param>
        /// <returns></returns>
        [HttpPost("forgotpassword")]
        //[ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordViewModel forgotPasswordViewModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(forgotPasswordViewModel);

            var user = await _userManager.FindByEmailAsync(forgotPasswordViewModel.Email);
            if (user == null)
                return BadRequest("Email not found");

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var callback = Url.Action(nameof(ResetPassword), "Users", new { token, email = user.Email }, Request.Scheme);

            string content = "Your username is: " + user.Email + ". Your password reset token is " + callback;
            content += "\n\n If you did not initiate for this password reset, kindly engage your systems administrator. Token is " + token;

            var mail = PrepareEmail(new List<EmailAddress>() { new EmailAddress() { Name = "RIMSMailer", Address = "appmailer@crystalisedapps.com" } },
                new List<EmailAddress>() { new EmailAddress() { Name = user.Email, Address = user.Email } },
                "New Credentials", content);

            await _emailService.Send(mail);

            return Ok("Email sent with password reset details");
        }

        /// <summary>
        /// Confirm the user email
        /// </summary>
        /// <param name="token"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        [HttpPost("confirmemail")]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail([FromBody] EmailConfirmationViewModel emailConfirmation)
        {
            var user = await _userManager.FindByEmailAsync(emailConfirmation.Email);
            if (user == null)
                return BadRequest("Invalid user email");

            var result = await _userManager.ConfirmEmailAsync(user, emailConfirmation.Token);

            var x = result;

            if (result.Succeeded)
            {
                // Set the password

                string content = "<h3>Thank you for taking time to validate your account.<h3> " +
                    "<p>Your account has been successfully activated and you may now proceed to login.</p>";

                var mail = PrepareEmail(new List<EmailAddress>() { new EmailAddress() { Name = "User Credentials", Address = "credentials@mcdss.gov.zm" } },
                    new List<EmailAddress>() { new EmailAddress() { Name = user.Email, Address = user.Email } },
                    "Email Confirmed", content);

                _emailService.Send(mail);

                return Ok(new { UserId = user.Id, IsFirstLogin = user.IsFirstLogin });
            }

            else
                return BadRequest("Failed to confirm email. Please try again later. " + result.ToString());
        }

        /// <summary>
        /// Change password initiated by user
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("changepassword")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangeUserPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {

                var user = await _userManager.FindByIdAsync(model.UserId);

                if (user != null)
                {
                    var result = await _userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);
                    if (result.Succeeded)
                    {
                        return Ok("Password successfully changed");
                    }
                    else
                        foreach (var error in result.Errors)
                            ModelState.TryAddModelError(error.Code, error.Description);

                    return BadRequest(ModelState);
                }


                return NotFound();
            }

            return BadRequest(model);
        }

        /// <summary>
        /// Change password initiated by user
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("setpasswordbyuserId")]
        [AllowAnonymous]
        public async Task<IActionResult> ForceChangePassword([FromBody] UserResetPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {

                var user = await _userManager.FindByIdAsync(model.UserId);

                if (user == null) throw new Exception($"User with Id {model.UserId} does not exist");
                else
                {
                    //1. Get token
                    var token = await _userManager.GeneratePasswordResetTokenAsync(user);

                    var resetPassResult = await _userManager.ResetPasswordAsync(user, token, model.Password);

                    if (!resetPassResult.Succeeded)
                    {
                        foreach (var error in resetPassResult.Errors)
                        {
                            ModelState.TryAddModelError(error.Code, error.Description);
                        }

                        return BadRequest(ModelState);
                    }

                    // Set IsFirstLogin to false
                    // user.IsFirstLogin = false;

                    // await _userManager.UpdateAsync(user);

                    return Ok("Password successfully reset");
                }
            }
            return BadRequest(ModelState);
        }

        /// <summary>
        /// Signout currently logged in user
        /// </summary>
        /// <returns></returns>
        [HttpPost("signout")]
        public async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return Ok("Successfully logged out");
        }

        /// <summary>
        /// Get list of all users - To be used by users with  admin module.
        /// They see all users across the system
        /// </summary>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<UserViewModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        // [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = _userManager.Users.ToList();

            var usersWithRoles = await AttachRoleToUsersList(users);

            // var UserViewModels = _mapper.Map<IList<UserMgtViewModel>>(users);
            return Ok(usersWithRoles.OrderByDescending(u => u.SubmissionDate));
        }

        /// <summary>
        /// Get user information for a single user by ID. If Id is 0 or nothing is passed it returns currently logged in user
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<UserViewModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id?}")]
        public async Task<IActionResult> GetById([FromRoute] string id = "0")
        {
            if (id == "0")
                id = _currentUserId;

            var user = await _userManager.FindByIdAsync(id);

            var userViewModel = await AttachRolesToUser(user);
            return Ok(userViewModel);
        }

        /// <summary>
        /// Get roles assigned to a user by user Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<UserViewModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetUserRolesByUserId([FromRoute] string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            // if the user Id is invalid
            if (user == null)
                return BadRequest("Invalid user Id provided");

            // Else get the roles associated with user
            var roles = await _userManager.GetRolesAsync(user);

            return Ok(roles);
        }


        /// <summary>
        /// Get a list of users in a role [all, staff or applicant] for valid strings
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<UserViewModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("[action]/{roleName}")]
        public async Task<IActionResult> GetUsersByRoleName([FromRoute] string roleName = "staff")
        {
            IList<User> users = new List<User>();

            if (roleName.ToLower() == "staff" || roleName.ToLower() == "all") // for staff or indeed all users
            {
                var allUsers = await _userManager.Users.ToListAsync();

                if (roleName.ToLower() == "all")
                    users = allUsers;
                else
                    foreach (var user in allUsers)
                    {
                        var userRoles = await _userManager.GetRolesAsync(user);
                        if (!userRoles.Contains("Applicant"))
                        {
                            users.Add(user);
                        }
                    }

            }
            else
                users = await _userManager.GetUsersInRoleAsync(roleName);

            var usersWithRoles = await AttachRoleToUsersList(users.ToList());

            return Ok(usersWithRoles.OrderByDescending(u => u.SubmissionDate));
        }

        /* public async Task<IActionResult> GetLeastBusyUserByRole([FromRoute] string roleName)
         {
             var usersInRole = await _userManager.GetUsersInRoleAsync(roleName);

             var leastBusyUser = usersInRole.Any(u => u.WorkflowInstances.Where(w => w.IsPicked == true).Count >0 ).FirstOrDefault();
         }*/

        /// <summary>
        /// Updates user given the userview values. Password is not updated from here.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="UserViewModel"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(User))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, [FromBody] UserViewModel UserViewModel)
        {
            var user = await _userManager.FindByIdAsync(id);


            if (user == null)
                return BadRequest($"User not found with this Id {id}");

            // Items to updated
            user.UserName = UserViewModel.UserName;
            user.Fullname = UserViewModel.Fullname;
            user.Email = UserViewModel.Email;
            user.PhoneNumber = UserViewModel.PhoneNumber;
            user.Description = UserViewModel.Description;
            user.EmailConfirmed = UserViewModel.EmailConfirmed.Value;
            user.LockoutEnabled = UserViewModel.LockoutEnabled.Value;
            user.IsFirstLogin = UserViewModel.IsFirstLogin;
            user.LockoutEnd = UserViewModel.LockoutEnd;
            user.IsActive = UserViewModel.IsActive.Value;


            // Update roles
            await UpdateUserRoles(UserViewModel, user);

            try
            {
                // save 
                await _userManager.UpdateAsync(user);

                var returnUser = await AttachRolesToUser(user);
                return CreatedAtAction("Update", new { id = returnUser.Id }, returnUser);
            }
            catch (Exception ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }

        /// <summary>
        /// Change active status of user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="UserViewModel"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(User))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("updateisactive/{id}")]
        public async Task<IActionResult> UpdateUserIsActive(string id, [FromBody] UserViewModel UserViewModel)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
                return BadRequest($"User not found with this Id {id}");

            user.IsActive = UserViewModel.IsActive;


            try
            {
                // save 
                await _userManager.UpdateAsync(user);

                return CreatedAtAction("Update", new { id = user.Id }, user);
            }
            catch (Exception ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }

        /// <summary>
        /// Change active status of multiple users
        /// </summary>
        /// <param name="isActive"></param>
        /// <param name="userIds"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(List<UserViewModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("updatemultipleisactive")]
        public async Task<IActionResult> UpdateMultipleUsersIsActive(bool isActive, [FromBody] List<string> userIds)
        {
            List<UserViewModel> userViewModels = new List<UserViewModel>();

            foreach (var userId in userIds)
            {
                var user = await _userManager.FindByIdAsync(userId);

                if (user == null)
                    continue;

                user.IsActive = isActive;

                // save 
                await _userManager.UpdateAsync(user);

                userViewModels.Add(_mapper.Map<UserViewModel>(user));
            }
            return CreatedAtAction("UpdateMultipleUsersIsActive", userViewModels);

        }

        /// <summary>
        /// Assisgns a user to a role
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        // [Authorize(Roles = "Admin")]

        [HttpPost("assignusertorole")]
        public async Task<IActionResult> AssignUserToRole([FromBody] NewUserRoleViewModel model)
        {
            if (ModelState.IsValid)
            {

                var user = await _userManager.FindByIdAsync(model.UserId);


                if (user != null)
                {
                    // Remove any existing roles
                    await RemoveUserFromCurrentRoles(user);

                    var result = await _userManager.AddToRoleAsync(user, model.RoleName);

                    if (!result.Succeeded)
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.TryAddModelError(error.Code, error.Description);
                        }

                        return BadRequest(ModelState);
                    }

                    return Ok($"User {user.UserName} successfully added to role {model.RoleName}!");
                }
            }
            return BadRequest(ModelState);
        }

        /// <summary>
        /// Remove user from role
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[Authorize(Roles = "Admin")]

        [HttpPost("removeuserfromrole")]
        public async Task<IActionResult> RemoveUserFromRole([FromBody] NewUserRoleViewModel model)
        {
            if (ModelState.IsValid)
            {

                var user = await _userManager.FindByIdAsync(model.UserId);

                if (user != null)
                {
                    var result = await _userManager.RemoveFromRoleAsync(user, model.RoleName);

                    if (!result.Succeeded)
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.TryAddModelError(error.Code, error.Description);
                        }

                        return BadRequest(ModelState);
                    }

                    return Ok($"User {user.UserName} successfully removed from role {model.RoleName}!");
                }
            }
            return BadRequest(ModelState);
        }

        /// <summary>
        /// Remove user from all current roles
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[Authorize(Roles = "Admin")]

        [HttpPost("removeuserfromcurrentroles")]
        public async Task<IActionResult> RemoveUserFromCurrentRoles([FromBody] User user)
        {
            if (ModelState.IsValid)
            {
                if (user != null)
                {
                    // Get all current roles for current user
                    var roles = await _userManager.GetRolesAsync(user);

                    foreach (var role in roles)
                    {
                        var result = await _userManager.RemoveFromRoleAsync(user, role);

                        if (!result.Succeeded)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.TryAddModelError(error.Code, error.Description);
                            }

                            return BadRequest(ModelState);
                        }
                    }
                    return Ok($"User {user.UserName} successfully removed from all roles!");
                }
            }
            return BadRequest(ModelState);
        }

        /// <summary>
        /// Delete user - Only SPECIAL ADMIN has this role
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<User>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(User model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            // await _userManager.Users.Del();
            return Ok(user);
        }

        /// <summary>
        /// Reset password by user Id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="UserViewModel"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("[action]/{id}")]
        public async Task<IActionResult> ResetPasswordByUserId(long id, [FromBody] UserResetPasswordViewModel UserViewModel)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Reset password of currently logged user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="UserViewModel"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("[action]/{id}")]
        public async Task<IActionResult> ResetPasswordByCurrentUserId(long id, [FromBody] UserResetPasswordViewModel UserViewModel)
        {
            throw new NotImplementedException();
        }


        // Prepare email message
        private EmailMessage PrepareEmail(List<EmailAddress> fromAddresses, List<EmailAddress> toAddresses,
            string subject, string content)
        {
            EmailMessage mail = new EmailMessage();

            mail.FromAddresses = fromAddresses;
            mail.ToAddresses = toAddresses;
            mail.Subject = subject;
            mail.Content = content;

            return mail;
        }

        // Generate a token string based on claims
        private string GenerateToken(ClaimsIdentity claimsIdentity, int tokenExpiryHours = 2)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = claimsIdentity,

                Expires = DateTime.UtcNow.AddHours(tokenExpiryHours),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            return tokenString;
        }

        // Generate claims list
        private async Task<ClaimsIdentity> GenerateClaimsAsync(User user)
        {
            var identity = new ClaimsIdentity(IdentityConstants.ApplicationScheme);
            identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.Id));
            identity.AddClaim(new Claim(ClaimTypes.Name, user.UserName));
            identity.AddClaim(new Claim(ClaimTypes.Email, user.Email));
            // Fullname
            identity.AddClaim(new Claim("fullname", user.Fullname));
            identity.AddClaim(new Claim("pictureUrl", user.PictureUrl == null ? string.Empty : user.PictureUrl));

            // Add user assigned roles
            //1. Get role
            var roles = await _userManager.GetRolesAsync(user);

            foreach (var role in roles)
                identity.AddClaim(new Claim(ClaimTypes.Role, role.ToLower()));

            return identity;
        }

        // Generate role name based on moduleName underscore user role
        private string GenerateCustomRoleName(string moduleName, string roleName)
        {
            // clean the strings
            moduleName = String.Concat(moduleName.Where(c => !Char.IsWhiteSpace(c))).ToLower();
            roleName = String.Concat(roleName.Where(c => !Char.IsWhiteSpace(c))).ToLower();

            return String.Concat(moduleName, '_', roleName);
        }

        /// <summary>
        /// Converts the uploaded base64Image and saves it as a .png 
        /// </summary>
        /// <param name="deposit"></param>
        private async Task<string> UploadConvertBase64ImageToFileImage(User user, string uploadType)
        {
            var fileUrl = Utils.Base64ImageToFileImage(user.PictureUrl, uploadType, user.Id);

            return fileUrl;
        }

        /// <summary>
        /// Attach a roles to a list of users
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        private async Task<IEnumerable<UserViewModel>> AttachRoleToUsersList(List<User> users)
        {
            // Create a list to store the user details along with roles
            var usersWithRoles = new List<UserViewModel>();

            // Retrieve all claims associated with each role
            foreach (var user in users)
            {
                // Get the roles assigned to the user
                var userRoles = await _userManager.GetRolesAsync(user);

                // Create a new UserWithRoles object to store user details
                var userWithRoles = _mapper.Map<UserViewModel>(user);

                userWithRoles.Roles = userRoles;

                // Add the user to the list
                usersWithRoles.Add(userWithRoles);
            }

            return usersWithRoles;
        }

        /// <summary>
        /// Attach a role to a single user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        private async Task<UserViewModel> AttachRolesToUser(User user)
        {
            // Get the roles assigned to the user
            var userRoles = await _userManager.GetRolesAsync(user);

            // Create a new UserWithRoles object to store user details
            var userWithRoles = _mapper.Map<UserViewModel>(user);

            userWithRoles.Roles = userRoles;

            return userWithRoles;
        }

        /// <summary>
        /// Update user roles based on the user and the updated view model
        /// </summary>
        /// <param name="viewModel"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        private async Task UpdateUserRoles(UserViewModel viewModel, User user)
        {
            // Get user current roles
            var userCurrentRoles = await _userManager.GetRolesAsync(user);

            var rolesToRemove = userCurrentRoles.Except(viewModel.Roles);
            // Remove roles
            if (rolesToRemove.Any())
            {
                foreach (var role in rolesToRemove)
                    await _userManager.RemoveFromRoleAsync(user, role);
            }

            //
            var rolesToAdd = viewModel.Roles.Except(userCurrentRoles);

            if (rolesToAdd.Any())
            {
                foreach (var role in rolesToAdd)
                    await _userManager.AddToRoleAsync(user, role);
            }
        }
    }
}
