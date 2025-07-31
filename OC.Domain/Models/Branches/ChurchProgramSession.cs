using OC.Domain.Interfaces;
using OC.Domain.Models.Accounting;

namespace OC.Domain.Models.Branches
{
    public class ChurchProgramSession : AuditableEntity, IEntityBase
    {
        public ChurchProgramSession() { 
            ChurchProgramSessionAttendances = new HashSet<ChurchProgramSessionAttendance>();
            ChurchProgramSessionVisitors = new HashSet<ChurchProgramSessionVisitor>();
            Expenses = new HashSet<Expense>();
            Incomes= new HashSet<Income>(); 
            Pledges= new HashSet<Pledge>();
        }   
        public long Id { get; set; }
        public long BranchId { get; set; }
        public long? ChurchProgramId { get; set; }
        public string Name { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }

        // Relationships
        public virtual Branch? Branch { get; set; }
        public virtual ChurchProgram? ChurchProgram { get; set; }
        public virtual ICollection<ChurchProgramSessionAttendance>? ChurchProgramSessionAttendances { get; set; }
        public virtual ICollection<ChurchProgramSessionVisitor>? ChurchProgramSessionVisitors { get; set; }
        public virtual ICollection<Expense>? Expenses { get; set; }
        public virtual ICollection<Income>? Incomes { get; set; }
        public virtual ICollection<Pledge>? Pledges { get; set; }
    }
}
