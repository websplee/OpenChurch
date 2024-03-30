using CrystalBLCore.BusinessServices.Interfaces;
using CrystalBLCore.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CrystalBLCore.BusinessServices
{
    public class TumaniSMSService : ITumaniSMSService
    {
        private HttpClient _httpClient;


        public TumaniSMSService(HttpClient httpClient)
        {
            _httpClient = httpClient;

        }

        public async Task<COMMAND> Post(REQUEST message, string url)
        {
            var xml = TumaniToXMLRequest(message);
            var request = new StringContent(xml, Encoding.UTF8, "application/xml");
            var responseMessage = await _httpClient.PostAsync(url, request);
            responseMessage.EnsureSuccessStatusCode();
            var newxml = xml;
            var simpleResponse = TumaniFromXMLResponse(await responseMessage.Content.ReadAsStringAsync());
            return simpleResponse;
        }

        String TumaniToXMLRequest(REQUEST request)
        {
            using (var stringwriter = new Utf8StringWriter())
            {
                var serializer = new XmlSerializer(request.GetType());
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("", "");
                serializer.Serialize(stringwriter, request, ns);
                return stringwriter.ToString();
            }
        }

        public COMMAND TumaniFromXMLResponse(string xmlResponse)
        {
            using (var stringReader = new System.IO.StringReader(xmlResponse))
            {
                var serializer = new XmlSerializer(typeof(COMMAND));
                return serializer.Deserialize(stringReader) as COMMAND;
            }
        }

        public class Utf8StringWriter : System.IO.StringWriter
        {
            public override Encoding Encoding
            {
                get { return Encoding.UTF8; }
            }
        }
    }
    

}
