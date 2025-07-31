using OC.Domain.Interfaces;
using OC.Domain.Models.Accounting;

namespace OC.Domain.Models.Branches
{
    public class Ministry : AuditableEntity, IEntityBase
    {
        public Ministry() {
            BranchMinistries = new HashSet<BranchMinistry>();
            Pledges= new HashSet<Pledge>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string? ShortName { get; set; }
        public string? Description { get; set; }

        // Relationships
        public virtual ICollection<BranchMinistry> BranchMinistries { get; set; }
        public virtual ICollection<Pledge> Pledges { get; set; }

    }
}
