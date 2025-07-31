namespace OC.Domain.ViewModels.Branches
{
    public class ChurchProgramViewModel
    {
        public ChurchProgramViewModel() {
            ChurchProgramSessions = new HashSet<ChurchProgramSessionViewModel>(); 
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }

        // Relationships
        public virtual ICollection<ChurchProgramSessionViewModel>? ChurchProgramSessions { get; set; }
    }
}
