using OC.Domain.Interfaces;
using OC.Domain.Models.Members;

namespace OC.Domain.Models.Branches
{
    public class CellGroup : AuditableEntity, IEntityBase
    {
        public CellGroup()
        {
            Members = new HashSet<Member>();
            CellLeaderships= new HashSet<CellLeadership>();
        }
        public long Id { get; set; }
        public long BranchId { get; set; }

        public string Name { get; set; }
        public string MeetingDay { get; set; }
        public string MeetingTime { get; set; }

        // Relationships
        public virtual Branch Branch { get; set; }
        public virtual ICollection<Member> Members { get; set; }
        public virtual ICollection<CellLeadership> CellLeaderships { get; set; }

    }
}
