﻿using OC.Domain.Interfaces;
using OC.Domain.Models.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC.Domain.Models.Branches
{
    public class CellLeadership : AuditableEntity, IEntityBase
    {
        public long Id { get; set; }
        public long CellGroupId { get; set; }
        public long LeadershipRoleId { get; set; }
        public long MemberId { get; set; }

        // Relationships
        public virtual CellGroup CellGroup { get; set; }
        public virtual LeadershipRole LeadershipRole { get; set; }
        public virtual Member Member { get; set; }
    }
}
