using OC.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC.Domain.Models.Branches
{
    public class BranchMinistry : AuditableEntity, IEntityBase
    {
        public BranchMinistry() { 
            BranchMinistryLeaderships= new HashSet<BranchMinistryLeadership>();
        }

        public long Id { get; set; }
        public long MinistryId { get; set;}
        public long BranchId { get; set; }

        // Relationships
        public virtual Branch Branch { get; set; }
        public virtual Ministry Ministry { get; set; }
        public virtual ICollection<BranchMinistryLeadership> BranchMinistryLeaderships { get; set; }
    }
}
