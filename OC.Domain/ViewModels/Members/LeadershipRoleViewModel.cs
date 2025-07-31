using OC.Domain.ViewModels.Branches;
using OC.Domain.ViewModels.Locations;

namespace OC.Domain.ViewModels.Members
{
    public class LeadershipRoleViewModel 
    {
        public LeadershipRoleViewModel() { 
            BranchMinistryLeaderships = new HashSet<BranchMinistryLeadershipViewModel>();
            CellLeaderships = new HashSet<CellLeadershipViewModel>();
            RegionLeaderships= new HashSet<RegionLeadershipViewModel>();
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public string? ShortName { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        // Relationships
        public virtual ICollection<BranchMinistryLeadershipViewModel> BranchMinistryLeaderships { get; set; }
        public virtual ICollection<CellLeadershipViewModel> CellLeaderships { get; set; }
        public virtual ICollection<RegionLeadershipViewModel> RegionLeaderships { get; set; }



    }
}
