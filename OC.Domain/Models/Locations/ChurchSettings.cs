using OC.Domain.Interfaces;
using OC.Domain.Models.Branches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace OC.Domain.Models.Locations
{
    public class ChurchSettings : AuditableEntity, IEntityBase
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FounderDetails { get; set; }
        public DateTime FoundingDate { get; set; }
        public bool IsActive { get; set; }
        
        public long? BranchId { get; set; }

        // Relationships
        public virtual Branch? Branch { get; set; }
    }
}
