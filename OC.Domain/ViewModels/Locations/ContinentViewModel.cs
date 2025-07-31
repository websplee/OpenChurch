using OC.Domain.Interfaces;

namespace OC.Domain.ViewModels.Locations
{
    public class ContinentViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int CountriesCount { get; set; }
        public int RegionsCount { get; set; }
        public int BranchesCount { get; set; }
        public bool IsActive { get; set; } = true;

        // Relationships
        // public virtual ICollection<CountryViewModel>?  Countries { get; set; }
    }
}
