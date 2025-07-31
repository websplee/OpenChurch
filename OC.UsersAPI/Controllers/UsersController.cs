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
            user.PictureUrl = !user.PictureUrl.IsNullOrEmpty() ? await UploadConvertBase64ImageToFileImage(user, "profile") : "";

            // Update the user
            await _userManager.UpdateAsync(user);

            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);

            // Convert to base64 
            token = Base64UrlEncoder.Encode(token);

            // var confirmationLink = Url.Action(nameof(ConfirmEmail), "Users", new { token, email = user.Email }, Request.Scheme);
            // var confirmationLink = Url.Action("auth", "activate-email", new { token, email = user.Email }, Request.Scheme);
            // 


            var basePath = $"{_configuration["EmailConfiguration:BaseUrl"]}{_configuration["EmailConfiguration:ActivateEmailUrl"]}";

            string activationUrl = $"{basePath}?token={token}&email={user.Email}";

            // string content = System.IO.File.ReadAllText("EmailTemplates/PasswordReset.htm");
            string content = System.IO.File.ReadAllText("EmailTemplates/index.html");

            // Replace #Username
            content = content.Replace("#Username", $"{user.Fullname}");

            // Replace #Action
            content = content.Replace("#Action", "your account has been successfully created!");

            // Replace #Content1
            var content1 = "We're excited to have you get started on the Open Church platform. Your account has been successfully created. Kindly activate your account by clicking the button below..";
            content = content.Replace("#Content1", content1);

            // Replace #ButtonText
            var buttonText = "Activate Account";
            content = content.Replace("#ButtonText", buttonText);

            // Replace #ButtonLink
            var buttonLink = activationUrl;
            content = content.Replace("#ButtonLink", buttonLink);

            // Replace #Content2
            var content2 = "DO NOT SHARE THIS EMAIL WITH ANYONE!!";
            content = content.Replace("#Content2", content2);

            // Replace #Content3
            var content3 = "";
            content = content.Replace("#Content3", content3);


            var mail = PrepareEmail(new List<EmailAddress>() { new EmailAddress() { Name = "OSMailer", Address = _configuration["EmailConfiguration:FromAddress"] } },
                new List<EmailAddress>() { new EmailAddress() { Name = user.Email, Address = user.Email } },
                "Successful Account Creation - Activate Your Account", content);


            await _emailService.Send(mail);

            var userViewModel = await AttachRolesToUser(user);

            return CreatedAtAction("Register", new { id = user.Id }, userViewModel);
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

            var resetPassResult = await _userManager.ResetPasswordAsync(user, Base64UrlEncoder.Decode(resetPasswordModel.Token), resetPasswordModel.Password);

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

            // Encode token
            token = Base64UrlEncoder.Encode(token);

            var basePath = $"{_configuration["EmailConfiguration:BaseUrl"]}{_configuration["EmailConfiguration:PasswordResetUrl"]}";

            string activationUrl = $"{basePath}?token={token}&email={user.Email}";

            // string content = System.IO.File.ReadAllText("EmailTemplates/PasswordReset.htm");
            string content = System.IO.File.ReadAllText("EmailTemplates/index.html");

            // Replace #Username
            content = content.Replace("#Username", $"{user.Fullname}");

            // Replace #Action
            content = content.Replace("#Action", "your password has been reset");

            // Replace #Content1
            var content1 = "You are receiving this email because you initiated a password reset on the RIMS platform. If you are the one who initiated this reset, proceed by clicking the button below..";
            content = content.Replace("#Content1", content1);

            // Replace #ButtonText
            var buttonText = "Password Reset";
            content = content.Replace("#ButtonText", buttonText);

            // Replace #ButtonLink
            var buttonLink = activationUrl;
            content = content.Replace("#ButtonLink", buttonLink);

            // Replace #Content2
            var content2 = "DO NOT SHARE THIS EMAIL WITH ANYONE!!";
            content = content.Replace("#Content2", content2);

            // Replace #Content3
            var content3 = "";
            content = content.Replace("#Content3", content3);


            var mail = PrepareEmail(new List<EmailAddress>() { new EmailAddress() { Name = "OSMailer", Address = _configuration["EmailConfiguration:FromAddress"] } },
                new List<EmailAddress>() { new EmailAddress() { Name = user.Email, Address = user.Email } },
                "Password Reset", content);


            await _emailService.Send(mail);

            return Ok("Email sent with password reset details");
        }

        /// <summary>
        /// Confirm the user email
        /// </summary>
        /// <param name="emailConfirmation"></param>
        /// <returns></returns>
        [HttpPost("confirmemail")]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail([FromBody] EmailConfirmationViewModel emailConfirmation)
        {
            var user = await _userManager.FindByEmailAsync(emailConfirmation.Email);
            if (user == null)
                return BadRequest("Invalid user email");

            // Check if the password is set
            var isPasswordNotSet = user.PasswordHash.IsNullOrEmpty();

            var result = await _userManager.ConfirmEmailAsync(user, Base64UrlEncoder.Decode(emailConfirmation.Token));


            if (result.Succeeded)
            {
                user.IsFirstLogin = false;

                // save 
                await _userManager.UpdateAsync(user);

                // If the password is not set we need to exit and return the password setting token and the user Id
                if (isPasswordNotSet)
                {
                    var token = await _userManager.GeneratePasswordResetTokenAsync(user);

                    // Encode token
                    token = Base64UrlEncoder.Encode(token);

                    return Ok(new { UserId = user.Id, IsFirstLogin = user.IsFirstLogin, Token = token });

                }

                var basePath = $"{_configuration["EmailConfiguration:BaseUrl"]}";

                // string content = System.IO.File.ReadAllText("EmailTemplates/PasswordReset.htm");
                string content = System.IO.File.ReadAllText("EmailTemplates/index.html");

                // Replace #Username
                content = content.Replace("#Username", $"{user.Fullname}");

                // Replace #Action
                content = content.Replace("#Action", "your account has been successfully activated!");

                // Replace #Content1
                var content1 = "Thank you for taking time to activate you account. You may now proceed to access the system by clicking the link below.";
                content = content.Replace("#Content1", content1);

                // Replace #ButtonText
                var buttonText = "System Link";
                content = content.Replace("#ButtonText", buttonText);

                // Replace #ButtonLink
                var buttonLink = basePath;
                content = content.Replace("#ButtonLink", buttonLink);

                // Replace #Content2
                var content2 = "DO NOT SHARE THIS EMAIL WITH ANYONE!!";
                content = content.Replace("#Content2", content2);

                // Replace #Content3
                var content3 = "";
                content = content.Replace("#Content3", content3);

                var mail = PrepareEmail(new List<EmailAddress>() { new EmailAddress() { Name = "OSMailer", Address = _configuration["EmailConfiguration:FromAddress"] } },
                    new List<EmailAddress>() { new EmailAddress() { Name = user.Email, Address = user.Email } },
                    "Account Successfully Activated", content);

                await _emailService.Send(mail);

                return Ok(new { UserId = user.Id, IsFirstLogin = user.IsFirstLogin, Token = string.Empty });
            }

            else
                return BadRequest("Failed to confirm email. Please try again later. " + result.ToString());
        }

        /// <summary>
        /// This link is used to resend the email activation link
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost("resendActivationEmail")]
        [AllowAnonymous]
        public async Task<IActionResult> ResendActivationEmailAsync(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);

            if (user == null)
            {
                // Handle user not found
                return Ok("If user exists, a reset email has been sent");
            }

            if (user.EmailConfirmed)
            {
                // User is already activated
                return Ok("Confirmed. If user exists, a reset email has been sent");
            }

            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);

            // Convert to base64 
            token = Base64UrlEncoder.Encode(token);

            // var confirmationLink = Url.Action(nameof(ConfirmEmail), "Users", new { token, email = user.Email }, Request.Scheme);
            // var confirmationLink = Url.Action("auth", "activate-email", new { token, email = user.Email }, Request.Scheme);
            // 


            var basePath = $"{_configuration["EmailConfiguration:BaseUrl"]}{_configuration["EmailConfiguration:ActivateEmailUrl"]}";

            string activationUrl = $"{basePath}?token={token}&email={user.Email}";

            // string content = System.IO.File.ReadAllText("EmailTemplates/PasswordReset.htm");
            string content = System.IO.File.ReadAllText("EmailTemplates/index.html");

            // Replace #Username
            content = content.Replace("#Username", $"{user.Fullname}");

            // Replace #Action
            content = content.Replace("#Action", "your account has been successfully created!");

            // Replace #Content1
            var content1 = "We're excited to have you get started on the RIMS platform. Your account has been successfully created. Kindly activate your account by clicking the button below..";
            content = content.Replace("#Content1", content1);

            // Replace #ButtonText
            var buttonText = "Activate Account";
            content = content.Replace("#ButtonText", buttonText);

            // Replace #ButtonLink
            var buttonLink = activationUrl;
            content = content.Replace("#ButtonLink", buttonLink);

            // Replace #Content2
            var content2 = "DO NOT SHARE THIS EMAIL WITH ANYONE!!";
            content = content.Replace("#Content2", content2);

            // Replace #Content3
            var content3 = "";
            content = content.Replace("#Content3", content3);


            var mail = PrepareEmail(new List<EmailAddress>() { new EmailAddress() { Name = "OSMailer", Address = _configuration["EmailConfiguration:FromAddress"] } },
                new List<EmailAddress>() { new EmailAddress() { Name = user.Email, Address = user.Email } },
                "Account Reactivation Link - Activate Your Account", content);


            await _emailService.Send(mail);

            return Ok("If user exists, activation email resent successfully.");
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
                { /*foreach (var user in allUsers)
                    {
                        var userRoles = await _userManager.GetRolesAsync(user);
                        if (!userRoles.Contains("Applicant"))
                        {
                            users.Add(user);
                        }
                    }*/
                    // get all applicants
                    var applicantUsers = await _userManager.GetUsersInRoleAsync("Applicant");

                    // users not applicants, assuming no applicant has another role
                    users = allUsers.Except(applicantUsers).ToList();
                }
            }
            else
                users = await _userManager.GetUsersInRoleAsync(roleName);

            var usersWithRoles = await AttachRoleToUsersList(users.ToList());

            return Ok(usersWithRoles.OrderByDescending(u => u.SubmissionDate));
        }

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
        /// <param name="isActive"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(User))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("updateisactive/{isActive}/{id}")]
        public async Task<IActionResult> UpdateUserIsActive(bool isActive, string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
                return BadRequest($"User not found with this Id {id}");

            user.IsActive = isActive;


            try
            {
                // save 
                await _userManager.UpdateAsync(user);
                // Get the roles assigned to the user
                var userRoles = await _userManager.GetRolesAsync(user);

                // Create a new UserWithRoles object to store user details
                var userWithRoles = _mapper.Map<UserViewModel>(user);

                userWithRoles.Roles = userRoles;

                return CreatedAtAction("Update", new { id = user.Id }, userWithRoles);
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

                // Get the roles assigned to the user
                var userRoles = await _userManager.GetRolesAsync(user);

                // Create a new UserWithRoles object to store user details
                var userWithRoles = _mapper.Map<UserViewModel>(user);

                userWithRoles.Roles = userRoles;

                userViewModels.Add(userWithRoles);
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
        /// <param name="id"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<User>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin, admin")]
        public async Task<IActionResult> Delete(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                return NotFound($"User with ID = {user.Id} cannot be found");
            }
            else
            {
                // Remove all roles associated with the user
                var roles = await _userManager.GetRolesAsync(user);
                if (roles.Count > 0)
                {
                    await _userManager.RemoveFromRolesAsync(user, roles);
                }

                // Delete the user
                var result = await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    return Ok($"User {user.UserName} has been successfully deleted."); // or wherever you want to redirect
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return BadRequest(ModelState); ; // return to the view with error messages
                }
            }
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