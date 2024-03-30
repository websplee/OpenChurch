using OC.Domain.Interfaces;
using OC.Domain.Models.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC.Domain.Models.Locations
{
    public class RegionLeadership : AuditableEntity, IEntityBase
    {
        public long Id { get; set; }
        public long RegionId { get; set; }
        public long LeadershipRoleId { get; set; }
        public long MemberId { get; set; }

        // Relationships
        public virtual Region? Region { get; set; }
        public virtual LeadershipRole? LeadershipRole { get; set; }
        public virtual Member? Member { get; set; }
    }
}
