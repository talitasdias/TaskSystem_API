using TaskSystem_API.Models;
using TaskSystem_API.Repositories.Interfaces;
using TaskSystem_API.Services.Interfaces;

namespace TaskSystem_API.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public Task<bool> Delete(int id)
        {
            return _userRepository.Delete(id);
        }

        public Task<List<UserModel>> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public Task<UserModel> GetById(int id)
        {
            return _userRepository.GetById(id);
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
