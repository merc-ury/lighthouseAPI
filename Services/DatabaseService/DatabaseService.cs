using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using LighthouseAPI.Models;
using LighthouseAPI.Entities;

namespace LighthouseAPI.Services
{
    public class DatabaseService : IDatabaseService
    {
        private readonly LighthouseContext _context;
        public DatabaseService(LighthouseContext context)
        {
            _context = context;   
        }

        public async Task<ServiceResponse<DbSet<Note>>> AddNote(Note note)
        {
            var response = new ServiceResponse<DbSet<Note>>();

            await _context.Notes.AddAsync(note);
            await _context.SaveChangesAsync();
            response.Data = _context.Notes;

            return response;
        }

        public async Task<ServiceResponse<DbSet<User>>> AddUser(User user)
        {
            var response = new ServiceResponse<DbSet<User>>();

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            response.Data = _context.Users;

            return response;
        }

        public async Task<ServiceResponse<DbSet<Note>>> GetAllNotes()
        {
            var response = new ServiceResponse<DbSet<Note>>();
            response.Data = _context.Notes;

            return response;
        }

        public async Task<ServiceResponse<DbSet<User>>> GetAllUsers()
        {
            var response = new ServiceResponse<DbSet<User>>();
            response.Data = _context.Users;

            return response;
        }

        public async Task<ServiceResponse<Note>> GetNoteByID(int id)
        {
            var response = new ServiceResponse<Note>();
            response.Data = _context.Notes.FirstOrDefault(note => note.NoteID == id);

            return response;
        }

        public async Task<ServiceResponse<User>> GetUserByID(int id)
        {
            var response = new ServiceResponse<User>();
            response.Data = _context.Users.FirstOrDefault(user => user.UserID == id);

            return response;
        }
    }
}