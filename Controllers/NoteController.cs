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
        private readonly IDatabaseService _dbService;
        public NoteController(IDatabaseService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet("get/all")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _dbService.GetAllUsers());
        }

        [HttpGet("get/user/{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            return Ok(await _dbService.GetUserByID(id));
        }

        [HttpPost("post/add")]
        public async Task<IActionResult> AddUser(User user)
        {
            return Ok(await _dbService.AddUser(user));
        }
    }
}