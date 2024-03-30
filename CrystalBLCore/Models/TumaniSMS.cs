using System;
using System.Collections.Generic;
using System.Text;

namespace CrystalBLCore.Models
{
    public class TumaniSMSRequest
    {
        public REQUEST REQUEST { get; set; }
        
    }
    
    public class REQUEST
    {
        public String REQUESTID { get; set; }
        public String REQUESTTYPE { get; set; }
        public DateTime DATE { get; set; }
        public AUTHENTICATION AUTHENTICATION { get; set; }
        public MESSAGE MESSAGE { get; set; }

    }

    public class AUTHENTICATION
    {
        public String USERID { get; set; }
        public String KEY { get; set; }
    }

    public class MESSAGE
    {
        public MESSAGE()
        {
            /*// Remove + from number
            if (MSISDN.Substring(0, 1) == "+")
                MSISDN = MSISDN.Replace("+","");
            // Append 26 if the number is 10 digits
            if (MSISDN.Length == 10)
                MSISDN = "26" + MSISDN;*/                
        }

        public String ORIGINATORID { get; set; }

        public String MSISDN { get; set; }
        public String TEXT { get; set; }
    }

    public class TumaniSMSResponse
    {
        public COMMAND COMMAND { get; set; }
    }

    public class COMMAND 
    {
        public RESPONSE RESPONSE { get; set; }
    }

    public class RESPONSE
    {
        public STATUS STATUS { get; set; }
    }

    public class STATUS
    {
        public string RESONCECODE { get; set; }
        public string DESCRIPTION { get; set; }
    }
}
