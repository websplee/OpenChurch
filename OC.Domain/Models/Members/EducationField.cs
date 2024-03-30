using OC.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC.Domain.Models.Members
{
    public class EducationField : AuditableEntity, IEntityBase
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
