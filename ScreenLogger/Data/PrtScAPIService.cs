using PrtScModels.Models;

namespace ScreenLogger.Data
{
    public  class PrtScAPIService
    {
       private readonly IHttpClientFactory ClientFactory;

        public async Task<HttpResponseMessage> GetPrtSc()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:7084/api/PrtSc/GetPrtSc");
            //  request.Headers.Add("User-Agent", "HttpClientFactory-Sample");
            using HttpClient client = new();
           // var client = ClientFactory.CreateClient();
           // client.BaseAddress = new Uri("https://localhost:7084/");
            var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            return response;
        }

        public async Task<string> GetInt()
        {
           await Task.Delay(1000);
            return "haha";
        }
    }
}