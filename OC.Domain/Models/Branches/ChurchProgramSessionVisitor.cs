using OC.Domain.Interfaces;

namespace OC.Domain.Models.Branches
{
    public class ChurchProgramSessionVisitor : AuditableEntity, IEntityBase
    {
        public long Id { get; set; }
        public long ChurchProgramSessionId { get; set; }
        // Add other fields
        public string? Name { get; set; }
        public string? MobileNumber { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public DateTime? DateVisited { get; set; }
        public DateTime? DateToVisit { get; set;}
        public bool? FollowedUp { get; set; }
        public string? Comments { get; set; }

        // Relationships
        public virtual ChurchProgramSession? ChurchProgramSession{ get; set; }
    }
}
