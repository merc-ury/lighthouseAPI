using System.Threading.Tasks;
using System.Collections.Generic;
using LighthouseAPI.Models;

namespace LighthouseAPI.Services
{
    public interface INoteService
    {
        Task<ServiceResponse<List<Note>>> GetAllNotes(int userID);
        Task<ServiceResponse<Note>> GetNoteByID(int id);
        Task<ServiceResponse<List<Note>>> AddNote(Note note);
        Task<ServiceResponse<Note>> UpdateNote(Note note);
        Task<ServiceResponse<List<Note>>> DeleteNote(int id);
    }
}