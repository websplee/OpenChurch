using OC.Domain.Interfaces;

namespace OC.Domain.Models
{
    public class AppSettings
    {
        public string Secret { get; set; }
        public IApproverLevels ApproverLevels { get; set; }
    }
}
