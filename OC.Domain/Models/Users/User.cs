using Microsoft.AspNetCore.Identity;
using OC.Domain.Interfaces;

namespace OC.Domain.Models.Users
{
    public class User : IdentityUser
    {
        
        public string? Description { get; set; }
        public string? PictureUrl { get; set; }
        public string Fullname { get; set; }

        // Maker Checker
        public string? MakerId { get; set; }
        public DateTime SubmissionDate { get; set; } = DateTime.UtcNow;
        public string? CheckerId { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public DateTime? RejectionDate { get; set; }
        public Boolean? IsActive { get; set; } = true;
        public Boolean? IsFirstLogin { get; set; } = false;
    }
}
