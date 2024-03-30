using OC.Domain.Interfaces;
using OC.Domain.Models.Accounting;
using OC.Domain.Models.Locations;
using OC.Domain.Models.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC.Domain.Models.Branches
{
    public class Branch : AuditableEntity, IEntityBase
    {
        public Branch()
        {
            Expenses = new HashSet<Expense>();
            Incomes = new HashSet<Income>();
            CellGroups = new HashSet<CellGroup>();
            Members = new HashSet<Member>();
            ChurchProgramSessions= new HashSet<ChurchProgramSession>();
        }
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


        // Relationships
        public virtual Region? Region { get; set; }
        public virtual ICollection<Expense>? Expenses { get; set; }
        public virtual ICollection<Income>? Incomes { get; set; }
        public virtual ICollection<CellGroup>? CellGroups { get; set; }
        public virtual ICollection<BranchMinistry>? BranchMinistries { get; set; }
        public virtual ICollection<Member>? Members { get; set; }
        public virtual ICollection<ChurchProgramSession>? ChurchProgramSessions { get; set; }

    }
}
