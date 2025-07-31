namespace OC.Domain.ViewModels.Branches
{
    public class BranchStaffViewModel
    {
        public long Id { get; set; }
        public string EmployeeNumber { get; set; }
        public long BranchId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Position { get; set; }
        public bool? IsActive { get; set; }
        // Relationships
        public virtual BranchViewModel Branch { get; set; }
    }
}
