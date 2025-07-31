namespace OC.Domain.ViewModels.Locations
{
    public class CountryViewModel
    {
        public long Id { get; set; }
        // Fk Continent Id
        public long ContinentId { get; set; }
        public string ContinentName { get; set; }
        public string? Code { get; set; }
        public string Name { get; set; }
        public int BanchesCount { get; set; }  // NOTE: Possible typo in TS: Should this be "Branches"?
        public int RegionsCount { get; set; }
        public bool IsActive { get; set; }

        // Relationships
        //public virtual ICollection<RegionViewModel> Regions { get; set; }
    }
}
