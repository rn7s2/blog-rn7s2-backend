using blog_rn7s2_backend.Data;
using blog_rn7s2_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace blog_rn7s2_backend.Controllers
{
    [ApiController]
    [Route("api/posts")]
    public class PostsController : ControllerBase
    {
        private readonly BlogContextSQLite _context;

        public PostsController(BlogContextSQLite context)
        {
            _context = context;
        }

        [HttpGet("overview")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<PostOverview>> GetPostsOverview()
        {
            if (_context.Posts == null)
                return StatusCode(StatusCodes.Status500InternalServerError);
            return _context.Posts.Select(post => new PostOverview
            {
                ID = post.ID,
                Title = post.Title,
                Author = post.Author,
                Abstract = post.Abstract,
                Updated = post.Updated
            }).ToList();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<Post> GetPost(int id)
        {
            if (_context.Posts == null)
                return StatusCode(StatusCodes.Status500InternalServerError);
            var results = _context.Posts.Where(post => post.ID == id);
            if (results.Count() == 0)
                return NotFound();
            if (results.Count() > 1)
                return StatusCode(StatusCodes.Status500InternalServerError);
            return results.First();
        }
    }
}
