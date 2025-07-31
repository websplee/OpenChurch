using OC.Domain.ViewModels.Members;

namespace OC.Domain.ViewModels.Branches
{
    public class BranchLeadershipViewModel 
    {
        public long Id { get; set; }
        public long BranchId { get; set; }
        public long LeadershipRoleId { get; set; }
        public long MemberId { get; set; }
        public bool IsActive { get; set; }

        // Relationships
        public virtual BranchViewModel Branch { get; set; }
        public virtual LeadershipRoleViewModel LeadershipRole { get; set; }
        public virtual MemberViewModel Member { get; set; }
    }
}
