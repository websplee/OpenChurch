using OC.Domain.ViewModels.Members;

namespace OC.Domain.ViewModels.Branches
{
    public class IncomingTransferViewModel 
    {
        public IncomingTransferViewModel()
        {
            IsAccepted = false; // Set acceptance to false
        }
        public long Id { get; set; }
        public long BranchId { get; set; }
        public string OldBranchName { get; set; }
        public long MemberId { get; set; }
        public string Notes { get; set; }
        public bool IsAccepted { get; set; }
        public bool IsActive { get; set; }

        // Relationships
        public virtual MemberViewModel Member { get; set; }
        public virtual BranchViewModel Branch { get; set; }
    }
}
