using OC.Domain.Interfaces;

namespace OC.Domain.ViewModels.Branches
{
    public class BranchMinistryViewModel 
    {
        public BranchMinistryViewModel() { 
            BranchMinistryLeaderships= new HashSet<BranchMinistryLeadershipViewModel>();
        }

        public long Id { get; set; }
        public long MinistryId { get; set;}
        public long BranchId { get; set; }

        // Relationships
        public virtual BranchViewModel Branch { get; set; }
        public virtual MinistryViewModel Ministry { get; set; }
        public virtual ICollection<BranchMinistryLeadershipViewModel> BranchMinistryLeaderships { get; set; }
    }
}
