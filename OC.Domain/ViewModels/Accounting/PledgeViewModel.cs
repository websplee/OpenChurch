using OC.Domain.ViewModels.Branches;
using OC.Domain.ViewModels.Members;

namespace OC.Domain.Models.Accounting
{
    public class PledgeViewModel 
    {
        public PledgeViewModel() { }

        public long Id { get; set; }
        public long? MemberId { get; set; }
        public long? MinistryId { get; set; }
        public long? ChurchProgramSessionId { get; set; }
        public string? Description { get; set; }
        public double Amount { get; set; }
        public double PaidAmount { get; set; } = 0;
        public DateTime? PaymentDate { get; set; }
        public DateTime? PaidDate { get; set; }
        public bool? IsRecurring { get; set; } = false;
        public int? RecurringReminderDay { get; set; } = 1;
        // TODO: INCLUDE LOGIC FOR INVOICING AND TRACKING OF PAYMENTS

        // Relationships
        public virtual MemberViewModel? Member { get; set; }
        public virtual MinistryViewModel? Ministry { get; set; }
        public virtual ChurchProgramSessionViewModel? ChurchProgramSession { get; set; }
    }
}
