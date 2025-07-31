using OC.Domain.Interfaces;
using OC.Domain.ViewModels.Members;

namespace OC.Domain.ViewModels.Branches
{
    public class CellGroupViewModel
    {
        
        public long Id { get; set; }
        public long BranchId { get; set; }

        public string Name { get; set; }
        public string MeetingDay { get; set; }
        public string MeetingTime { get; set; }
        public int MemberCount { get; set; }
        public int CellLeadershipCount { get; set; }

        public bool? IsActive { get; set; }
        // Contact Information From Host Member
        public string HostFullname { get; set; }
        public string BranchName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public double? Latitude { get; set; } = 0.0;
        public double? Longitude { get; set; } = 0.0;
        public string MobileNumber { get; set; }
        // Relationships
        //public virtual BranchViewModel Branch { get; set; }
        public virtual ICollection<MemberViewModel> Members { get; set; }
        public virtual ICollection<CellLeadershipViewModel> CellLeaderships { get; set; }

    }
}
