using Microsoft.AspNetCore.Mvc;

namespace blog_rn7s2_backend.Controllers
{
    [ApiController]
    [Route("api/posts")]
    public class PostsController : ControllerBase
    {
        [HttpGet("overview")]
        public IEnumerable<string> GetPostsOverview()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("{id}")]
        public string GetPost(int id)
        {
            return "value";
        }
    }
}
