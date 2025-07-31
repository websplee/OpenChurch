namespace OC.Domain.ViewModels.Branches
{
    public class CellGroupNewViewModel
    {
        public long BranchId { get; set; }

        public string Name { get; set; }
        public string MeetingDay { get; set; }
        public string MeetingTime { get; set; }
        public long HostMemberId { get; set; }
        public bool? IsActive { get; set; }
    }
}
