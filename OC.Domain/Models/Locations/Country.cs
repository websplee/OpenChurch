using OC.Domain.Interfaces;

namespace OC.Domain.Models.Locations
{
    public class Country : AuditableEntity, IEntityBase
    {
        public Country()
        {
            Regions = new HashSet<Region>();
        }
        public long Id { get; set; }
        // Fk Continent Id
        public long ContinentId { get; set; }
        public string? Code { get; set; }
        public string Name { get; set; }

        // Relationships
        public virtual Continent? Continent { get; set; }
        public virtual ICollection<Region>? Regions { get; set; }
    }
}
