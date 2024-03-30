using OC.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC.Domain.Models.Branches
{
    public class ChurchProgram : AuditableEntity, IEntityBase
    {
        public ChurchProgram() {
            ChurchProgramSessions = new HashSet<ChurchProgramSession>(); 
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        // Relationships
        public virtual ICollection<ChurchProgramSession>? ChurchProgramSessions { get; set; }
    }
}
