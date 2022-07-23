using blog_rn7s2_backend.Data;
using blog_rn7s2_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace blog_rn7s2_backend.Controllers
{
    [ApiController]
    [Route("api/config")]
    public class ConfigController : ControllerBase
    {
        private readonly BlogContextSQLite _context;

        public ConfigController(BlogContextSQLite context)
        {
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<Config> GetConfig()
        {
            if (_context.Configs == null)
                return StatusCode(StatusCodes.Status500InternalServerError);
            return _context.Configs.First();
        }
    }
}
