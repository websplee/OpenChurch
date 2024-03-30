using OC.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC.Domain.Models.Branches
{
    public class BranchStaff : AuditableEntity, IEntityBase
    {
        public long Id { get; set; }
        public string EmployeeNumber { get; set; }
        public long BranchId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Position { get; set; }

        // Relationships
        public virtual Branch Branch { get; set; }
    }
}
