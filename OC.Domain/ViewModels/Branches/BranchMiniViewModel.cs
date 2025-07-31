using OC.Domain.ViewModels.Accounting;
using OC.Domain.ViewModels.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC.Domain.ViewModels.Branches
{
    public class BranchMiniViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string Pastor { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int MembersCount { get; set; }
        public int CellGroupsCount { get; set; }
        public DateTime Established { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
        // public FinancesViewModel? Finances { get; set; }
        // public MembersDataViewModel? Members { get; set; }
        // public CellGroupsDataViewModel? CellGroups { get; set; }
        // public ChurchProgramSessionEventViewModel? Events { get; set; }
    }
}
