using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using LighthouseAPI.Models;
using LighthouseAPI.Entities;

namespace LighthouseAPI.Services
{
    public class NoteService : INoteService
    {
        private readonly LighthouseContext _context;
        public NoteService(LighthouseContext context)
        {
            _context = context;    
        }

        public async Task<ServiceResponse<List<Note>>> AddNote(Note note)
        {
            var response = new ServiceResponse<List<Note>>();

            await _context.Notes.AddAsync(note);
            await _context.SaveChangesAsync();
            response.Data = await _context.Notes.ToListAsync();

            return response;
        }

        public async Task<ServiceResponse<List<Note>>> DeleteNote(int id)
        {
            var response = new ServiceResponse<List<Note>>();

            var note = _context.Notes.FirstOrDefault(n => n.NoteID == id);
            _context.Notes.Remove(note);
            await _context.SaveChangesAsync();
            response.Data = await _context.Notes.ToListAsync();

            return response;
        }

        public async Task<ServiceResponse<List<Note>>> GetAllNotes(int userID)
        {
            var response = new ServiceResponse<List<Note>>();
            var notes = await _context.Notes.Where(note => note.UserID == userID).ToListAsync();
            response.Data = notes;

            return response;
        }

        public async Task<ServiceResponse<Note>> GetNoteByID(int id)
        {
            await Task.Delay(0);
            var response = new ServiceResponse<Note>();
            response.Data = _context.Notes.FirstOrDefault(note => note.NoteID == id);

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
    }
}