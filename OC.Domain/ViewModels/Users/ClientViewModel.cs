using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OC.Domain.ViewModels.Users
{
    public class ClientViewModel
    {
        public long Id { get; set; }
        public string ClientName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public string ContactPersonFullname { get; set; }
        public string ContactPersonMobileNumber { get; set; }
        public string ContactPersonEmail { get; set; }
    }
}
