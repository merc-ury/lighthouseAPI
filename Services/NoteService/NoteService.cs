using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace LighthouseAPI
{
    public class NoteService : INoteService
    {
        public async Task<ServiceResponse<List<UserModel>>> AddUser(UserModel user)
        {
            var response = new ServiceResponse<List<UserModel>>();

            MockData.users.Add(user);
            response.Data = MockData.users;

            return response;
        }

        public async Task<ServiceResponse<List<UserModel>>> GetAllUsers()
        {
            var response = new ServiceResponse<List<UserModel>>();
            response.Data = MockData.users;

            return response;
        }

        public async Task<ServiceResponse<UserModel>> GetUserByID(int id)
        {
            var response = new ServiceResponse<UserModel>();
            response.Data = MockData.users.FirstOrDefault(user => user.UserID == id);
            
            return response;
        }
    }
}