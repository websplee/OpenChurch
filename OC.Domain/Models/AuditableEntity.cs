using OC.Domain.Interfaces;
using System;

namespace OC.Domain.Models
{
    public class AuditableEntity : IAuditableEntity
    {
        public string? MakerId { get; set; }
        public DateTime SubmissionDate { get; set; }
        public string? CheckerId { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public DateTime? RejectionDate { get; set; }
        public Boolean? IsActive { get; set; }
    }
}
