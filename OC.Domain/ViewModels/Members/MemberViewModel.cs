using OC.Domain.Models.Accounting;
using OC.Domain.Models.Branches;
using OC.Domain.Models.Members;
using OC.Domain.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC.Domain.ViewModels.Members
{
    public class MemberViewModel
    {
        public long Id { get; set; }
        public long? BranchId { get; set; }
        public string? BranchName { get; set; }
        public long? CellGroupId { get; set; }
        public string? CellGroupName { get; set; }
        public long? SpouseId { get; set; }
        public string? SpouseName { get; set; }
        public long? FamilyId { get; set; }
        public long? FamilyName { get; set; }
        public string? UserId { get; set; }
        public string? UserUserName { get; set; }
        public string? Code { get; set; }
        public string? Title { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime? DateBornAgain { get; set; }
        public DateTime? DateBaptised { get; set; }
        public DateTime? DateJoined { get; set; }
        public string? Occupation { get; set; }
        public string EducationLevel { get; set; }
        public long EducationLevelId { get; set; }
        public string? PictureUrl { get; set; }
        public string MaritalStatus { get; set; }

        // Contact Information
        public string Address { get; set; }
        public string City { get; set; }
        public double? Latitude { get; set; } = 0.0;
        public double? Longitude { get; set; } = 0.0;
        public string MobileNumber { get; set; }
        public bool IsActive { get; set; }

        // Relationships
        

        public virtual ICollection<BranchMinistryLeadership> BranchMinistryLeaderships { get; set; }
        public virtual ICollection<Pledge> Pledges { get; set; }
    }
}
