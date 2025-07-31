using OC.Domain.ViewModels.Branches;

namespace OC.Domain.ViewModels.Locations
{
    public class RegionViewModel 
    {
        public long Id { get; set; }
        // FK Country
        public long CountryId { get; set; }
        public string Name { get; set; }
        public string CountryName { get; set; }
        public string ContinentName { get; set; }
        public string? OfficeLocation { get; set; }
        public int BranchesCount { get; set; }
        public int RegionLeadershipsCount { get; set; }
        public bool IsActive { get; set; }

        // Relationships
        /*public virtual ICollection<BranchViewModel>? Branches { get; set; }
        public virtual ICollection<RegionLeadershipViewModel>? RegionLeaderships { get; set; }*/
    }
}
