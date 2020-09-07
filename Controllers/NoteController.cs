using System;
using Microsoft.AspNetCore.Mvc;

namespace LighthouseAPI
{
    [ApiController]
    [Route("[controller]")]
    public class NoteController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult Get(int userID)
        {
            // TODO: Get all the notes from userID
            return Ok("Hello world!");
        }
    }
}