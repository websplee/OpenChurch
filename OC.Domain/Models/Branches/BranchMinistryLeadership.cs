using OC.Domain.Interfaces;
using OC.Domain.Models.Members;

namespace OC.Domain.Models.Branches
{
    public class BranchMinistryLeadership : AuditableEntity, IEntityBase
    {
        public long Id { get; set; }
        // Branch Ministry for which we are defining the leadership role for the ministry
        public long BranchMinistryId { get; set; }

        // Leadership Role
        public long LeadershipRoleId { get; set; }
        // Position Holder
        public long MemberId { get; set; }

        // Relashionships
        public virtual BranchMinistry BranchMinistry { get; set; }
        public virtual LeadershipRole LeadershipRole { get; set; }
        public virtual Member Member { get; set; }
    }
}
