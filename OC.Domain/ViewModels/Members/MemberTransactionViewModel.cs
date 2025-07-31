namespace OC.Domain.ViewModels.Members
{
    public class MemberTransactionViewModel
    {
        public long Id { get; set; }
        public long MemberId { get; set; }
        public long TransactionTypeId { get; set; }
        public double Amount { get; set; }
        public string Purpose { get; set; }
        public string Narration { get; set; }
        public DateTime TransactionDateTime { get; set; }

        // Relationships
        public virtual MemberViewModel? Member { get; set; }
        public virtual TransactionTypeViewModel? TransactionType { get; set; }
    }
}
