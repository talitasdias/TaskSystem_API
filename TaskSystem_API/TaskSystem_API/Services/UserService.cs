using TaskSystem_API.Models;
using TaskSystem_API.Services.Interfaces;

namespace TaskSystem_API.Services
{
    public class UserService : IUserService
    {
        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserModel>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<UserModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserModel> Register(UserModel userModel)
        {
            throw new NotImplementedException();
        }

        public Task<UserModel> Update(UserModel userModel, int id)
        {
            throw new NotImplementedException();
        }
    }
}
