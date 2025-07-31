using OC.Domain.ViewModels.Accounting;
using OC.Domain.ViewModels.Locations;
using OC.Domain.ViewModels.Members;

namespace OC.Domain.ViewModels.Branches
{
    public class BranchViewModel 
    {
        public BranchViewModel()
        {
            Expenses = new HashSet<ExpenseViewModel>();
            Incomes = new HashSet<IncomeViewModel>();
            CellGroups = new HashSet<CellGroupViewModel>();
            Members = new HashSet<MemberViewModel>();
            ChurchProgramSessions= new HashSet<ChurchProgramSessionViewModel>();
        }
        public long Id { get; set; }
        public long RegionId { get; set; }
        public string Name { get; set; }
        public string PhysicalAddress { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool OwnBuilding { get; set; }
        public bool IsActive { get; set; }


        // Relationships
        public virtual RegionViewModel? Region { get; set; }
        public virtual ICollection<ExpenseViewModel>? Expenses { get; set; }
        public virtual ICollection<IncomeViewModel>? Incomes { get; set; }
        public virtual ICollection<CellGroupViewModel>? CellGroups { get; set; }
        public virtual ICollection<BranchMinistryViewModel>? BranchMinistries { get; set; }
        public virtual ICollection<MemberViewModel>? Members { get; set; }
        public virtual ICollection<ChurchProgramSessionViewModel>? ChurchProgramSessions { get; set; }

    }
}
