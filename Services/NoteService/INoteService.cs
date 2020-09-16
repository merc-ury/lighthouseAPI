using System.Threading.Tasks;
using System.Collections.Generic;
using LighthouseAPI.Models;

namespace LighthouseAPI.Services
{
    public interface INoteService
    {
        Task<ServiceResponse<List<User>>> GetAllUsers();
        Task<ServiceResponse<User>> GetUserByID(int id);
        Task<ServiceResponse<List<User>>> AddUser(User user);
    }
}