using CrystalBLCore.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CrystalBLCore.BusinessServices.Interfaces
{
    public interface ITumaniSMSService
    {
        // Task<HttpResponseMessage> Post(TumaniSMSRequest message, string url);
        Task<COMMAND> Post(REQUEST message, string url);
    }
}
