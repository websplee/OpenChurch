using OC.Domain.Interfaces;
using OC.Domain.Models.Branches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC.Domain.Models.Locations
{
    public class Region : AuditableEntity, IEntityBase
    {
        public Region()
        {
            Branches = new HashSet<Branch>();
            RegionLeaderships= new HashSet<RegionLeadership>();
        }

        public long Id { get; set; }
        // FK Country
        public long CountryId { get; set; }
        public string Name { get; set; }
        public string? OfficeLocation { get; set; }

        // Relationships
        public virtual ICollection<Branch>? Branches { get; set; }
        public virtual ICollection<RegionLeadership>? RegionLeaderships { get; set; }
    }
}
