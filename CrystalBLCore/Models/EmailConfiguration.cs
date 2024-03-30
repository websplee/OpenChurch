using CrystalBLCore.Models.Interfaces;

namespace CrystalBLCore.Models
{
    public class EmailConfiguration : IEmailConfiguration
    {
        public string SmtpServer { get; set; }
        public int SmtpPort { get; set; }
        public string SmtpUsername { get; set; }
        public string SmtpPassword { get; set; }

        public string PopServer { get; set; }
        public int PopPort { get; set; }
        public string PopUsername { get; set; }
        public string PopPassword { get; set; }
        public string Subject { get; set; }
        public string AltSubject { get; set; }
        public string Url { get; set; }
        public string AltUrl { get; set; }
        public string FromAddress { get; set; }
        public string FromName { get; set; }
        public string AltFromAddress { get; set; }
    }
}
