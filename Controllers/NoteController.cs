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

        [HttpGet("get/{id}/all")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _noteService.GetAllNotes(id));
        }

        [HttpGet("get/{id}")]
        public async Task<IActionResult> GetNote(int id)
        {
            return Ok(await _noteService.GetNoteByID(id));
        }

        [HttpGet("get/count")]
        public async Task<IActionResult> GetNoteCount()
        {
            return Ok(await _noteService.GetNoteCount());
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddNote(Note note)
        {
            return Ok(await _noteService.AddNote(note));
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateNote(Note note)
        {
            return Ok(await _noteService.UpdateNote(note));
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteNote(int id)
        {
            return Ok(await _noteService.DeleteNote(id));
        }
    }
}