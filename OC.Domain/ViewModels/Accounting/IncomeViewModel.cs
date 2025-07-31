using OC.Domain.ViewModels.Accounting;
using OC.Domain.ViewModels.Branches;
using OC.Domain.ViewModels.Members;

namespace OC.Domain.ViewModels.Accounting
{
    public class IncomeViewModel
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
        public virtual BranchViewModel? Branch { get; set; }
        public virtual ChurchProgramSessionViewModel? ChurchProgramSession { get; set; }
        public virtual MemberViewModel? Member { get; set; }
        public virtual IncomeTypeViewModel? IncomeType { get; set; }
    }
}
