using OC.Domain.Models.Accounting;
using OC.Domain.ViewModels.Accounting;

namespace OC.Domain.ViewModels.Branches
{
    public class ChurchProgramSessionViewModel 
    {
        public ChurchProgramSessionViewModel() { 
            ChurchProgramSessionAttendances = new HashSet<ChurchProgramSessionAttendanceViewModel>();
            ChurchProgramSessionVisitors = new HashSet<ChurchProgramSessionVisitorViewModel>();
            Expenses = new HashSet<ExpenseViewModel>();
            Incomes= new HashSet<IncomeViewModel>(); 
            Pledges= new HashSet<PledgeViewModel>();
        }   
        public long Id { get; set; }
        public long BranchId { get; set; }
        public long? ChurchProgramId { get; set; }
        public string Name { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool? IsActive { get; set; }

        // Relationships
        public virtual BranchViewModel? Branch { get; set; }
        public virtual ChurchProgramViewModel? ChurchProgram { get; set; }
        public virtual ICollection<ChurchProgramSessionAttendanceViewModel>? ChurchProgramSessionAttendances { get; set; }
        public virtual ICollection<ChurchProgramSessionVisitorViewModel>? ChurchProgramSessionVisitors { get; set; }
        public virtual ICollection<ExpenseViewModel>? Expenses { get; set; }
        public virtual ICollection<IncomeViewModel>? Incomes { get; set; }
        public virtual ICollection<PledgeViewModel>? Pledges { get; set; }
    }
}
