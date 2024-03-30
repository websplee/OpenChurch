using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace OC.Domain.ViewModels.Users
{
    public class UserViewModel
    {
        public string Id { get; set; }
        public string Fullname { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string? PictureUrl { get; set; }
        public bool? EmailConfirmed { get; set; }
        public bool? LockoutEnabled { get; set; }
        public bool? IsLockedout { get; set; }
        public bool? IsFirstLogin { get; set; }
        public DateTime? LockoutEnd { get; set; }
        public string? MakerId { get; set; }
        public DateTime SubmissionDate { get; set; } = DateTime.UtcNow;
        public string? CheckerId { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public DateTime? RejectionDate { get; set; }
        public Boolean? IsActive { get; set; } = true;

        // Relationships
        public ICollection<string>? Roles { get; set; }
    }
}
