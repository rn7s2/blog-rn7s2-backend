using blog_rn7s2_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace blog_rn7s2_backend.Controllers
{
    [ApiController]
    [Route("api/config")]
    public class ConfigController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public Config Get()
        {
            return new Config();
        }
    }
}
