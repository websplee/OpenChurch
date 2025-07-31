using OC.Domain.Interfaces;
using OC.Domain.Models.Branches;
using OC.Domain.Models.Locations;

namespace OC.Domain.Models.Members
{
    public class LeadershipRole : AuditableEntity, IEntityBase
    {
        public LeadershipRole() { 
            BranchMinistryLeaderships = new HashSet<BranchMinistryLeadership>();
            CellLeaderships = new HashSet<CellLeadership>();
            RegionLeaderships= new HashSet<RegionLeadership>();
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public string? ShortName { get; set; }
        public string? Description { get; set; }

        // Relationships
        public virtual ICollection<BranchMinistryLeadership> BranchMinistryLeaderships { get; set; }
        public virtual ICollection<CellLeadership> CellLeaderships { get; set; }
        public virtual ICollection<RegionLeadership> RegionLeaderships { get; set; }



    }
}
