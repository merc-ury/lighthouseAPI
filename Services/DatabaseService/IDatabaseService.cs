using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using LighthouseAPI.Models;

namespace LighthouseAPI.Services
{
    public interface IDatabaseService
    {
        Task<ServiceResponse<List<User>>> GetAllUsers();
        Task<ServiceResponse<User>> GetUserByID(int id);
        Task<ServiceResponse<List<User>>> AddUser(User user);
        Task<ServiceResponse<User>> UpdateUser(User user);
        Task<ServiceResponse<List<User>>> DeleteUser(int id);
        Task<ServiceResponse<List<Note>>> GetAllNotes(int userID);
        Task<ServiceResponse<Note>> GetNoteByID(int id);
        Task<ServiceResponse<List<Note>>> AddNote(Note note);
        Task<ServiceResponse<Note>> UpdateNote(Note note);
        Task<ServiceResponse<List<Note>>> DeleteNote(int id);
    }
}