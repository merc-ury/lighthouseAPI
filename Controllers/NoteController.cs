using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LighthouseAPI.Models;
using LighthouseAPI.Services;

namespace LighthouseAPI
{
    [ApiController]
    [Route("api/[controller]")]
    public class NoteController : ControllerBase
    {
        private readonly INoteService _noteService;
        public NoteController(INoteService noteService)
        {
            _noteService = noteService;
        }

        [HttpGet("get/all")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _noteService.GetAllUsers());
        }

        [HttpGet("get/user/{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            return Ok(await _noteService.GetUserByID(id));
        }

        [HttpPost("post/add")]
        public async Task<IActionResult> AddUser(User user)
        {
            return Ok(await _noteService.AddUser(user));
        }
    }
}