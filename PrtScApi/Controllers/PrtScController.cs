using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrtScModels.Models;

namespace PrtScApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrtScController : ControllerBase
    {
        public PrtScStatus prtsc = new PrtScStatus("DOWN", "YFWxJdBMhrdM4CfYhxpAhotF0SCwSmAVRn52YPq3iIv");

        [HttpGet]
        [Route("GetPrtSc")]
        public IActionResult GetPrtSc()
        {
            return Ok(prtsc);
        }
        /*
        [HttpPost]
        [Route("PostPrtSc")]
        public IActionResult PostPrtSc([FromBody] string status, [FromBody] string token)
        {
            prtsc.Status = status;
            prtsc.Token = token;

            return Ok();
        }
        */
    }
}
