namespace OC.Domain.ViewModels.Branches
{
    public class BranchNewViewModel
    {
        public long Id { get; set; }
        public long RegionId { get; set; }
        public string Name { get; set; }
        public string PhysicalAddress { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool OwnBuilding { get; set; }
        public bool IsActive { get; set; }

    }
}
