using OC.Domain.Interfaces;
using OC.Domain.Models.Accounting;
using OC.Domain.Models.Branches;
using OC.Domain.Models.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace OC.Domain.Models.Members
{
    public class Member : AuditableEntity, IEntityBase
    {
        public Member() { 
            BranchMinistryLeaderships= new HashSet<BranchMinistryLeadership>();
            Pledges= new HashSet<Pledge>();
        }

        // Member Information
        public long Id { get; set; }
        public long? BranchId { get; set; }
        public long? CellGroupId { get; set; }
        public long? SpouseId { get; set; }
        public long? FamilyId { get; set; }
        public string? UserId { get; set; }
        public string? Code { get; set; }
        public string? Title { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime? DateBornAgain { get; set; }
        public DateTime? DateBaptised{ get; set; }
        public DateTime? DateJoined{ get; set; }
        public string? Occupation { get; set; }
        public long EducationLevelId { get; set; }
        public string? PictureUrl { get; set; }
        public string MaritalStatus { get; set; }

        // Contact Information
        public string Address { get; set; }
        public string City { get; set; }
        public double? Latitude { get; set; } = 0.0;
        public double? Longitude { get; set; } = 0.0;
        public string MobileNumber { get; set; }

        // Relationships
        public virtual User? User { get; set; }
        public virtual Branch? Branch { get; set; }
        [ForeignKey(nameof(SpouseId))]
        public virtual Member? Spouse { get; set; }
        public virtual Family? Family { get; set; }
        
        public virtual CellGroup? CellGroup { get; set; }

        public virtual ICollection<BranchMinistryLeadership> BranchMinistryLeaderships { get; set; }
        public virtual ICollection<Pledge> Pledges { get; set; }


    }
}
