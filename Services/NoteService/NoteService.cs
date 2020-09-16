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

        public async Task<ServiceResponse<DbSet<User>>> AddUser(User user)
        {
            var response = new ServiceResponse<DbSet<User>>();

            _context.Users.Add(user);
            response.Data = _context.Users;

            return response;
        }

        public async Task<ServiceResponse<DbSet<User>>> GetAllUsers()
        {
            var response = new ServiceResponse<DbSet<User>>();
            response.Data = _context.Users;

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