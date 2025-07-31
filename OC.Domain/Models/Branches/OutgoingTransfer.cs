using OC.Domain.Interfaces;
using OC.Domain.Models.Members;

namespace OC.Domain.Models.Branches
{
    public class OutgoingTransfer : AuditableEntity, IEntityBase
    {
        public OutgoingTransfer()
        {
            IsAccepted = false; // Set acceptance to false
        }
        public long Id { get; set; }
        public long BranchId { get; set; }
        public string OldBranchName { get; set; }
        public long MemberId { get; set; }
        public string Notes { get; set; }
        public bool IsAccepted { get; set; }

        // Relationships
        public virtual Member Member { get; set; }
        public virtual Branch Branch { get; set; }
    }
}
