using OC.Domain.Interfaces;
using OC.Domain.Models.Members;

namespace OC.Domain.Models.Branches
{
    public class BranchLeadership : AuditableEntity, IEntityBase
    {
        public long Id { get; set; }
        public long BranchId { get; set; }
        public long LeadershipRoleId { get; set; }
        public long MemberId { get; set; }
        public bool IsActive { get; set; }

        // Relationships
        public virtual Branch Branch { get; set; }
        public virtual LeadershipRole LeadershipRole { get; set; }
        public virtual Member Member { get; set; }
    }
}
