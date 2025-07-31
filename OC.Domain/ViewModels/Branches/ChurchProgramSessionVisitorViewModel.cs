namespace OC.Domain.ViewModels.Branches
{
    public class ChurchProgramSessionVisitorViewModel
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
        public bool? IsActive { get; set; }

        // Relationships
        public virtual ChurchProgramSessionViewModel? ChurchProgramSession{ get; set; }
    }
}
