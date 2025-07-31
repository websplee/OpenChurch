namespace OC.Domain.ViewModels.Locations
{
    public class RegionLeadershipViewModel
    {
        public long Id { get; set; }
        public long RegionId { get; set; }
        public string RegionName { get; set; }
        public long LeadershipRoleId { get; set; }
        public string LeadershipRoleName { get; set; }
        public long MemberId { get; set; }
        public string MemberName { get; set; }
        public string MemberPictureUrl { get; set; }
        public bool IsActive { get; set; }
    }
}
