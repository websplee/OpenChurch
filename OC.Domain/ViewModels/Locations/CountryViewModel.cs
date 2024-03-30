using OC.Domain.Models.Locations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC.Domain.ViewModels.Locations
{
    public class CountryViewModel
    {
        public long Id { get; set; }
        // Fk Continent Id
        public long ContinentId { get; set; }
        public string ContinentName { get; set; }
        public string? Code { get; set; }
        public string Name { get; set; }

        // Relationships
        public virtual ICollection<Region> Regions { get; set; }
    }
}
