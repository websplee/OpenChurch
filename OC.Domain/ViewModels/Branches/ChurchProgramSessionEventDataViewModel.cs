using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC.Domain.ViewModels.Branches
{
    public class ChurchProgramSessionEventDataViewModel
    {
        public virtual ICollection<ChurchProgramSessionEventViewModel>? Upcoming { get; set; }
        public virtual ICollection<ChurchProgramSessionEventViewModel>? Recent { get; set; }
    }
}
