using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrtScModels.Models;

namespace PrtScApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrtScController : ControllerBase
    {
        [HttpGet]
        [Route("GetPrtSc")]
        public IActionResult GetPrtSc()
        {
            PrtSc prtsc = new PrtSc();
            prtsc.Status = "DOWN";
            prtsc.Token = "YFWxJdBMhrdM4CfYhxpAhotF0SCwSmAVRn52YPq3iIv";

            return Ok(prtsc);
        }
    }
}
