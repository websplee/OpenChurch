namespace OC.Domain.ViewModels.Locations
{
    public class ChurchSettingsViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string FounderDetails { get; set; }
        public DateTime FoundingDate { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
        public long? BranchId { get; set; }

        // Branch Details 
        public long BranchRegionId { get; set; }
        public string BranchName { get; set; }
        public string BranchPhysicalAddress { get; set; }
        public string BranchPhone1 { get; set; }
        public string BranchPhone2 { get; set; }
        public string BranchEmail { get; set; }
        public double BranchLatitude { get; set; }
        public double BranchLongitude { get; set; }
        public bool BranchOwnBuilding { get; set; }
    }
}
