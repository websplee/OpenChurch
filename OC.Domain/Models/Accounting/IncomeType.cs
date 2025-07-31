using OC.Domain.Interfaces;

namespace OC.Domain.Models.Accounting
{
    public class IncomeType : AuditableEntity, IEntityBase
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
