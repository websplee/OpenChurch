namespace OC.Domain.ViewModels.Branches
{
    public class CellGroupsDataViewModel
    {
        public int Total { get; set; }
        public int Active { get; set; }
        public double AverageSize { get; set; }
        public int TotalMembers { get; set; }
        public List<CellGroupViewModel>? Groups { get; set; }
    }
}
