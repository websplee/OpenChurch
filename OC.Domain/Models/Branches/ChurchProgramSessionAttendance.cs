using OC.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC.Domain.Models.Branches
{
    public class ChurchProgramSessionAttendance : AuditableEntity, IEntityBase
    {
        public long Id { get; set; }
        public long ChurchProgramSessionId { get; set; }
        public int? TotalMen { get; set; }
        public int? TotalWomen { get; set; }
        public int? TotalYouthMen { get; set; }
        public int? TotalYouthWomen { get; set; }
        public int? TotalBoys { get; set; }
        public int? TotalGirls { get; set; }

        // Relationships
        public virtual ChurchProgramSession? ChurchProgramSession { get; set; }
    }
}
