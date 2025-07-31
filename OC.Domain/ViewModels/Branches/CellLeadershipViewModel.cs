using OC.Domain.ViewModels.Members;

namespace OC.Domain.ViewModels.Branches
{
    public class CellLeadershipViewModel 
    {
        public long Id { get; set; }
        public long CellGroupId { get; set; }
        public long LeadershipRoleId { get; set; }
        public long MemberId { get; set; }
        public bool? IsActive { get; set; }

        // Relationships
        public virtual CellGroupViewModel CellGroup { get; set; }
        public virtual LeadershipRoleViewModel LeadershipRole { get; set; }
        public virtual MemberViewModel Member { get; set; }
    }
}
