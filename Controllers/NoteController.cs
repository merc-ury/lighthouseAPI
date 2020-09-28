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
            return Ok(await _dbService.GetAllNotes());
        }

        [HttpGet("get/{id}")]
        public async Task<IActionResult> GetNote(int id)
        {
            return Ok(await _dbService.GetNoteByID(id));
        }

        [HttpPost("post/add")]
        public async Task<IActionResult> AddNote(Note note)
        {
            return Ok(await _dbService.AddNote(note));
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateNote(Note note)
        {
            return Ok(await _dbService.UpdateNote(note));
        }
    }
}