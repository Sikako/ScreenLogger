namespace PrtScModels.Models
{
    public class PrtScApi : IPrtScApi
    {
        PrtScStatus prtsc = new("DOWN", "YFWxJdBMhrdM4CfYhxpAhotF0SCwSmAVRn52YPq3iIv");
        public PrtScStatus GetPrtSc()
        {
            return prtsc;
        }
        public bool Update(PrtScStatus updated_prtsc)
        {
            if (updated_prtsc == null)
            {
                throw new ArgumentNullException("updated_prtsc");
            }
            prtsc.Status = updated_prtsc.Status;
            prtsc.Token = updated_prtsc.Token;
            return true;
        }
    }
}
