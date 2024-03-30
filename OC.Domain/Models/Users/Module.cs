using OC.Domain.Interfaces;
using System.Collections.Generic;

namespace OC.Domain.Models.Users
{
    public class Module : AuditableEntity, IEntityBase
    {
        public Module()
        {
            RoleModules = new HashSet<RoleModule>();
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<RoleModule> RoleModules { get; set; }
    }
}
