using System.Threading.Tasks;
using System.Collections.Generic;
using LighthouseAPI.Models;

namespace LighthouseAPI.Services
{
    public interface IUserService
    {
        Task<ServiceResponse<List<User>>> GetAllUsers();
        Task<ServiceResponse<User>> GetUserByID(int id);
        Task<ServiceResponse<User>> AddUser(User user);
        Task<ServiceResponse<User>> UpdateUser(User user);
        Task<ServiceResponse<List<User>>> DeleteUser(int id);
    }
}