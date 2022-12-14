using PrtScModels.Models;

namespace ScreenLogger.Data
{
    public interface IPrtScService
    {
        Task<PrtSc> GetPrtSc();
    }
}
