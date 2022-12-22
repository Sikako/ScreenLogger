namespace PrtScModels.Models
{
    public interface IPrtScApi
    {
        PrtScStatus GetPrtSc();
        bool Update(PrtScStatus updated_prtsc);
    }
}
