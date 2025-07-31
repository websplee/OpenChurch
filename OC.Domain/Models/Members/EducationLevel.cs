using OC.Domain.Interfaces;

namespace OC.Domain.Models.Members
{
    public class EducationLevel : AuditableEntity, IEntityBase
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
