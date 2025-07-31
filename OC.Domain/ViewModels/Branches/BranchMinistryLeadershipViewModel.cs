using OC.Domain.Interfaces;
using OC.Domain.ViewModels.Members;

namespace OC.Domain.ViewModels.Branches
{
    public class BranchMinistryLeadershipViewModel 
    {
        public long Id { get; set; }
        // Branch Ministry for which we are defining the leadership role for the ministry
        public long BranchMinistryId { get; set; }

        // Leadership Role
        public long LeadershipRoleId { get; set; }
        // Position Holder
        public long MemberId { get; set; }
        public bool? IsActive { get; set; }

        // Relashionships
        public virtual BranchMinistryViewModel BranchMinistry { get; set; }
        public virtual LeadershipRoleViewModel LeadershipRole { get; set; }
        public virtual MemberViewModel Member { get; set; }
    }
}
