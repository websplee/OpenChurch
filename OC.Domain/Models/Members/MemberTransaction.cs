using OC.Domain.Interfaces;

namespace OC.Domain.Models.Members
{
    public class MemberTransaction : AuditableEntity, IEntityBase
    {
        public long Id { get; set; }
        public long MemberId { get; set; }
        public long TransactionTypeId { get; set; }
        public double Amount { get; set; }
        public string Purpose { get; set; }
        public string Narration { get; set; }
        public DateTime TransactionDateTime { get; set; }

        // Relationships
        public virtual Member? Member { get; set; }
        public virtual TransactionType? TransactionType { get; set; }
    }
}
