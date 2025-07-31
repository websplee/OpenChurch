namespace OC.Domain.ViewModels.Branches
{
    public class ChurchProgramSessionAttendanceViewModel 
    {
        public long Id { get; set; }
        public long ChurchProgramSessionId { get; set; }
        public int? TotalMen { get; set; }
        public int? TotalWomen { get; set; }
        public int? TotalYouthMen { get; set; }
        public int? TotalYouthWomen { get; set; }
        public int? TotalBoys { get; set; }
        public int? TotalGirls { get; set; }
        public bool? IsActive { get; set; }

        // Relationships
        public virtual ChurchProgramSessionViewModel? ChurchProgramSession { get; set; }
    }
}
