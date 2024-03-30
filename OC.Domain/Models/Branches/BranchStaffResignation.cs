using OC.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC.Domain.Models.Branches
{
    public class BranchStaffResignation : AuditableEntity, IEntityBase
    {
        public long Id { get; set; }
        public long BranchStaffId { get; set; }
        public DateTime ResignationDate { get; set; }
        public string Reason { get; set; }
    }
}
