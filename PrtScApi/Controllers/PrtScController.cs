using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrtScModels.Models;

namespace PrtScApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrtScController : ControllerBase
    {
        static readonly IPrtScApi prtscapi = new PrtScModels.Models.PrtScApi();

        [HttpGet]
        [Route("GetPrtSc")]
        public IActionResult GetPrtSc()
        {
            return Ok(prtscapi.GetPrtSc());
        }
  
       
        [HttpPost]
        [Route("PostPrtSc")]
        public IActionResult PostPrtSc(PrtScStatus updated_prtsc)
        {
            return Ok(prtscapi.Update(updated_prtsc));
        }

       
    }
}
