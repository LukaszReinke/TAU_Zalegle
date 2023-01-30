using Microsoft.AspNetCore.Mvc;

namespace TAU_Web_Api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class TauController : ControllerBase
    {
        [HttpGet("FirstController")]
        public async Task FirstController()
        {

        }
    }
}
