using System;
using Microsoft.AspNetCore.Mvc;

namespace LighthouseAPI
{
    [ApiController]
    [Route("[controller]")]
    public class NoteController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello world!");
        }
    }
}