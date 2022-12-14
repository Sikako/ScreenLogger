using PrtScModels.Models;

namespace ScreenLogger.Data
{
    public class PrtScer : IPrtScService
    {
        private readonly HttpClient httpClient;
        public PrtScer(HttpClient _httpClient)
        {
            this.httpClient = _httpClient;
        }

        public async Task<PrtSc> GetPrtSc()
        {
            return await httpClient.GetFromJsonAsync<PrtSc>("api/PrtSc/GetPrtSc");
        }
    }
}
