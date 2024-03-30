using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace CrystalBLCore.Models
{
    [DataContract]
    public class ApiResponse
    {

        [DataMember]
        public string Version { get { return "1.0"; } }

        [DataMember]
        public int StatusCode { get; set; }
        [DataMember]
        public bool IsSuccess { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public object? ErrorMessage { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public object? Result { get; set; }

        public ApiResponse(int statusCode, string result = null, string  message = null, bool isSuccess = true)
        {
            StatusCode = statusCode;
            Result = result != null ? JsonConvert.DeserializeObject(result) : result;
            ErrorMessage = message != null ? JsonConvert.DeserializeObject(message) : message;
            IsSuccess = isSuccess;
        }

        public ApiResponse() { }
    }    
}
