using OC.Domain.Interfaces;
using OC.Domain.Models.Branches;
using OC.Domain.Models.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC.Domain.Models.Accounting
{
    public class Income : AuditableEntity, IEntityBase
    {
        public long Id { get; set; }
        public long BranchId { get; set; }
        public long? ChurchProgramSessionId { get; set; }
        public long? MemberId { get; set; }
        public long IncomeTypeId { get; set; }
        public DateTime TrxDate { get; set; }
        public double Amount { get; set; }
        public string? Reference { get; set; }
        public string? Description { get; set; }
        public string? TrxSource { get; set; } // Mobile MNO Name, Bank Name

        // Relationship
        public virtual Branch? Branch { get; set; }
        public virtual ChurchProgramSession? ChurchProgramSession { get; set; }
        public virtual Member? Member { get; set; }
        public virtual IncomeType? IncomeType { get; set; }
    }
}
