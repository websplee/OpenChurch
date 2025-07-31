using OC.Domain.ViewModels.Members;

namespace OC.Domain.ViewModels.Branches
{
    public class CellGroupHostViewModel
    {
        public long Id { get; set; }
        public long CellGroupId { get; set; }
        public long MemberId { get; set; }
        public bool? IsActive { get; set; }
        
        // Contact Information From Host Member
        public string Address { get; set; }
        public string City { get; set; }
        public double? Latitude { get; set; } = 0.0;
        public double? Longitude { get; set; } = 0.0;
        public string MobileNumber { get; set; }

        // Relationships
        public virtual CellGroupViewModel CellGroup { get; set; }
        public virtual MemberViewModel Host { get; set; }
    }
}
