namespace OC.Domain.ViewModels.Members
{
    public class MembersDataViewModel
    {
        public int Total { get; set; }
        public int Active { get; set; }
        public int New { get; set; }
        public int Inactive { get; set; }
        public double Growth { get; set; }
        public List<AgeGroupViewModel>? AgeGroups { get; set; }
        public List<RecentMemberViewModel>? RecentMembers { get; set; }
    }
}
