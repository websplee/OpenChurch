using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using OC.Domain.Models.Users;
using System.Security.Claims;

namespace OC.UsersAPI.Factories
{
    public class CustomClaimsFactory : UserClaimsPrincipalFactory<User>
    {
        public CustomClaimsFactory(UserManager<User> userManager, IOptions<IdentityOptions> optionsAccessor)
            : base(userManager, optionsAccessor)
        {
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(User user)
        {
            var identity = new ClaimsIdentity(IdentityConstants.ApplicationScheme);
            identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.Id));
            identity.AddClaim(new Claim(ClaimTypes.Name, user.UserName));
            identity.AddClaim(new Claim(ClaimTypes.Email, user.Email));
            identity.AddClaim(new Claim("fullname", user.Fullname));
            identity.AddClaim(new Claim("pictureUrl", user.PictureUrl == null ? string.Empty : user.PictureUrl));

            // Add user assigned roles
            //1. Get role
            var roles = await UserManager.GetRolesAsync(user);

            foreach (var role in roles)
                identity.AddClaim(new Claim(ClaimTypes.Role, role.ToLower()));

            return identity;
        }
    }
}