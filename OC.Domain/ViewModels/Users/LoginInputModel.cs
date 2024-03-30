using System.ComponentModel.DataAnnotations;

namespace OC.Domain.ViewModels.Users
{
    public class LoginInputModel
    {
        public LoginInputModel() { RememberLogin = false; ReturnUrl = null; }

        [Required(ErrorMessage = "emailRequired")]
        public string Email { get; set; }
        [Required(ErrorMessage = "passwordRequired")]
        public string Password { get; set; }
        public bool? RememberLogin { get; set; }
        public string? ReturnUrl { get; set; }
    }
}
