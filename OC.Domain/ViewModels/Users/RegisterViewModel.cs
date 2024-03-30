using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace OC.Domain.ViewModels.Users
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Please enter valid email address")]        
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "PictureUrl")]
        public string PictureUrl { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [Display(Name = "Fullname")]
        public string Fullname { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "PhoneNumber")]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public ICollection<String>? Roles { get; set; }
    }
}
