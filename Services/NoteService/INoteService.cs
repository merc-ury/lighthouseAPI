using System.Collections.Generic;

namespace LighthouseAPI
{
    public interface INoteService
    {
        List<UserModel> GetAllUsers();
        UserModel GetUserByID(int id);
        List<UserModel> AddUser(UserModel user);
    }
}