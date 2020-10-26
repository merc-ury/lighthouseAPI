using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using LighthouseAPI.Models;
using LighthouseAPI.Entities;

namespace LighthouseAPI.Services
{
    public class UserService : IUserService
    {
        private readonly LighthouseContext _context;
        public UserService(LighthouseContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<User>>> AddUser(User user)
        {
            var response = new ServiceResponse<List<User>>();

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            response.Data = await _context.Users.ToListAsync();

            return response;
        }

        public async Task<ServiceResponse<List<User>>> DeleteUser(int id)
        {
            var response = new ServiceResponse<List<User>>();

            var user = _context.Users.FirstOrDefault(u => u.UserID == id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            response.Data = await _context.Users.ToListAsync();

            return response;
        }

        public async Task<ServiceResponse<List<User>>> GetAllUsers()
        {
            var response = new ServiceResponse<List<User>>();
            response.Data = await _context.Users.ToListAsync();

            return response;
        }

        public async Task<ServiceResponse<User>> GetUserByID(int id)
        {
            await Task.Delay(0);
            var response = new ServiceResponse<User>();
            response.Data = _context.Users.FirstOrDefault(user => user.UserID == id);

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