﻿using blog_rn7s2_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace blog_rn7s2_backend.Controllers
{
    [ApiController]
    [Route("api/pages")]
    public class PagesController : ControllerBase
    {
        [HttpGet("{name}")]
        public Page Get(string name)
        {
            return new Page();
        }
    }
}