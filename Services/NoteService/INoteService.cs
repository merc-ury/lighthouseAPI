using System.Threading.Tasks;
using System.Collections.Generic;

namespace LighthouseAPI
{
    public interface INoteService
    {
        Task<ServiceResponse<List<UserModel>>> GetAllUsers();
        Task<ServiceResponse<UserModel>> GetUserByID(int id);
        Task<ServiceResponse<List<UserModel>>> AddUser(UserModel user);
    }
}