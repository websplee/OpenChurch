namespace OC.Domain.ViewModels.Branches
{
    public class BranchStaffResignationViewModel
    {
        public long Id { get; set; }
        public long BranchStaffId { get; set; }
        public string? BranchStaffFirstname { get; set; }
        public string? BranchStaffLastname { get; set; }
        public DateTime ResignationDate { get; set; }
        public string Reason { get; set; }
    }
}
