using OC.Domain.Interfaces;
using OC.Domain.Models.Members;

namespace OC.Domain.Models.Branches
{
    public class CellGroupHost : AuditableEntity, IEntityBase
    {
        public long Id { get; set; }
        public long CellGroupId { get; set; }
        public long MemberId { get; set; }

        // Relationships
        public virtual CellGroup? CellGroup { get; set; }
        public virtual Member? Host { get; set; }
    }
}
