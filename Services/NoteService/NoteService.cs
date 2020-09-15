using System.Collections.Generic;
using System.Linq;

namespace LighthouseAPI
{
    public class NoteService : INoteService
    {
        public List<UserModel> AddUser(UserModel user)
        {
            MockData.users.Add(user);
            return MockData.users;
        }

        public List<UserModel> GetAllUsers()
        {
            return MockData.users;
        }

        public UserModel GetUserByID(int id)
        {
            return MockData.users.FirstOrDefault(user => user.UserID == id);
        }
    }
}