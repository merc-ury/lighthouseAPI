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
    }
}