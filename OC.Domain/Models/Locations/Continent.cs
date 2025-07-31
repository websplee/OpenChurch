using OC.Domain.Interfaces;

namespace OC.Domain.Models.Locations
{
    public class Continent : AuditableEntity, IEntityBase
    {
        public Continent()
        {
            Countries = new HashSet<Country>();
        }
        public long Id { get; set; }
        public string Name { get; set; }

        // Relationships
        public virtual ICollection<Country>?  Countries { get; set; }
    }
}
