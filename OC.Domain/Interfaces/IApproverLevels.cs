using System;
using System.Collections.Generic;
using System.Text;

namespace OC.Domain.Interfaces
{
    public interface IApproverLevels
    {
        string ApproverLevelType { get; set; }
        int ApproverLevelValue { get; set; }
    }
}
