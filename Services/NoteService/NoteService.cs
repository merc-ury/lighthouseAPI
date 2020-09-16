using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using LighthouseAPI.Models;

namespace LighthouseAPI.Services
{
    public class NoteService : INoteService
    {
        public async Task<ServiceResponse<List<User>>> AddUser(User user)
        {
            var response = new ServiceResponse<List<User>>();

            MockData.users.Add(user);
            response.Data = MockData.users;

            return response;
        }

        public async Task<ServiceResponse<List<User>>> GetAllUsers()
        {
            var response = new ServiceResponse<List<User>>();
            response.Data = MockData.users;

            return response;
        }

        public async Task<ServiceResponse<User>> GetUserByID(int id)
        {
            var response = new ServiceResponse<User>();
            response.Data = MockData.users.FirstOrDefault(user => user.UserID == id);

            return response;
        }
    }
}