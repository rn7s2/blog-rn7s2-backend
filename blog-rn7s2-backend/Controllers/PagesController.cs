using blog_rn7s2_backend.Data;
using blog_rn7s2_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace blog_rn7s2_backend.Controllers
{
    [ApiController]
    [Route("api/pages")]
    public class PagesController : ControllerBase
    {
        private readonly BlogContextSQLite _context;

        public PagesController(BlogContextSQLite context)
        {
            _context = context;
        }

        [HttpGet("config")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<PageConfig>> GetPagesConfig()
        {
            if (_context.Pages == null)
                return StatusCode(StatusCodes.Status500InternalServerError);
            return _context.Pages.Select(page => new PageConfig
            {
                Name = page.Name,
                Title = page.Title
            }).ToList();
        }

        [HttpGet("{name}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<Page> GetPage(string name)
        {
            if (_context.Pages == null)
                return StatusCode(StatusCodes.Status500InternalServerError);
            var results = _context.Pages.Where(page => page.Name == name);
            if (results.Count() == 0)
                return NotFound();
            if (results.Count() > 1)
                return StatusCode(StatusCodes.Status500InternalServerError);
            return results.First();
        }
    }
}
