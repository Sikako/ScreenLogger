using PrtScModels.Models;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;
using System.Net.NetworkInformation;
using System.Text.Json.Serialization;
using System.Net.Http;

namespace ScreenLogger.Data
{
    public class PrtScAPI : PrtScAPIService
    {
        /*
        IHttpClientFactory ClientFactory;
        
        public HttpResponseMessage GetPrtSc()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:7084/api/PrtSc/GetPrtSc");
            request.Headers.Add("User-Agent", "HttpClientFactory-Sample");

            var client = ClientFactory.CreateClient();
            var response =  client.Send(request);
            return response;
        }
        */
    }
}