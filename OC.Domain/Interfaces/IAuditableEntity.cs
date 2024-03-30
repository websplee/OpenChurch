using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OC.Domain.Interfaces
{
    public interface IAuditableEntity
    {
        string? MakerId { get; set; }
        DateTime SubmissionDate { get; set; }
        string? CheckerId { get; set; }
        DateTime? ApprovalDate { get; set; }
        DateTime? RejectionDate { get; set; }
        Boolean? IsActive { get; set; }
    }
}
