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

        public async Task<ServiceResponse<DbSet<Note>>> DeleteNote(int id)
        {
            var response = new ServiceResponse<DbSet<Note>>();

            var note = _context.Notes.FirstOrDefault(n => n.NoteID == id);
            _context.Notes.Remove(note);
            await _context.SaveChangesAsync();
            response.Data = _context.Notes;

            return response;
        }

        public async Task<ServiceResponse<DbSet<User>>> DeleteUser(int id)
        {
            var response = new ServiceResponse<DbSet<User>>();

            var user = _context.Users.FirstOrDefault(u => u.UserID == id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            response.Data = _context.Users;

            return response;
        }

        public async Task<ServiceResponse<DbSet<Note>>> GetAllNotes()
        {
            await Task.Delay(0);
            var response = new ServiceResponse<DbSet<Note>>();
            response.Data = _context.Notes;

            return response;
        }

        public async Task<ServiceResponse<DbSet<User>>> GetAllUsers()
        {
            await Task.Delay(0);
            var response = new ServiceResponse<DbSet<User>>();
            response.Data = _context.Users;

            return response;
        }

        public async Task<ServiceResponse<Note>> GetNoteByID(int id)
        {
            await Task.Delay(0);
            var response = new ServiceResponse<Note>();
            response.Data = _context.Notes.FirstOrDefault(note => note.NoteID == id);

            return response;
        }

        public async Task<ServiceResponse<User>> GetUserByID(int id)
        {
            await Task.Delay(0);
            var response = new ServiceResponse<User>();
            response.Data = _context.Users.FirstOrDefault(user => user.UserID == id);

            return response;
        }

        public async Task<ServiceResponse<Note>> UpdateNote(Note note)
        {
            var response = new ServiceResponse<Note>();

            Note updatedNote = _context.Notes.FirstOrDefault(n => n.NoteID == note.NoteID);
            updatedNote.NoteID = note.NoteID;
            updatedNote.UserID = note.UserID;
            updatedNote.Title = note.Title;
            updatedNote.Content = note.Content;
            updatedNote.Category = note.Category;
            updatedNote.Priority = note.Priority;
            updatedNote.CreatedOn = note.CreatedOn;

            response.Data = updatedNote;

            _context.Notes.Update(updatedNote);
            await _context.SaveChangesAsync();

            return response;
        }

        public async Task<ServiceResponse<User>> UpdateUser(User user)
        {
            var response = new ServiceResponse<User>();

            User updatedUser = _context.Users.FirstOrDefault(u => u.UserID == user.UserID);
            updatedUser.UserID = user.UserID;
            updatedUser.Email = user.Email;
            updatedUser.Name = user.Name;
            updatedUser.CreatedOn = user.CreatedOn;

            response.Data = updatedUser;

            _context.Users.Update(updatedUser);
            await _context.SaveChangesAsync();

            return response;
        }
    }
}