using OC.Domain.Models.Accounting;

namespace OC.Domain.ViewModels.Branches
{
    public class MinistryViewModel
    {
        public MinistryViewModel() {
            BranchMinistries = new HashSet<BranchMinistryViewModel>();
            Pledges= new HashSet<PledgeViewModel>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string? ShortName { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;

        // Relationships
        public virtual ICollection<BranchMinistryViewModel> BranchMinistries { get; set; }
        public virtual ICollection<PledgeViewModel> Pledges { get; set; }

    }
}
