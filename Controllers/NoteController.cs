using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LighthouseAPI
{
    [ApiController]
    [Route("[controller]")]
    public class NoteController : ControllerBase
    {
        private readonly INoteService _noteService;
        public NoteController(INoteService noteService)
        {
            _noteService = noteService;
        }

        [HttpGet("get/GetAll")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _noteService.GetAllUsers());
        }

        [HttpGet("get/{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            return Ok(await _noteService.GetUserByID(id));
        }

        [HttpPost("new")]
        public async Task<IActionResult> AddUser(UserModel user)
        {
            return Ok(await _noteService.AddUser(user));
        }
    }
}