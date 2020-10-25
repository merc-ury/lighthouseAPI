using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using LighthouseAPI.Models;

namespace LighthouseAPI.Services
{
    public interface IDatabaseService
    {
        Task<ServiceResponse<DbSet<User>>> GetAllUsers();
        Task<ServiceResponse<User>> GetUserByID(int id);
        Task<ServiceResponse<DbSet<User>>> AddUser(User user);
        Task<ServiceResponse<User>> UpdateUser(User user);
        Task<ServiceResponse<DbSet<User>>> DeleteUser(User user);
        Task<ServiceResponse<DbSet<Note>>> GetAllNotes();
        Task<ServiceResponse<Note>> GetNoteByID(int id);
        Task<ServiceResponse<DbSet<Note>>> AddNote(Note note);
        Task<ServiceResponse<Note>> UpdateNote(Note note);
        Task<ServiceResponse<DbSet<Note>>> DeleteNote(Note note);
    }
}