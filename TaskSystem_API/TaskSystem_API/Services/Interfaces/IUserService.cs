using TaskSystem_API.Models;

namespace TaskSystem_API.Services.Interfaces
{
    public interface IUserService
    {
        Task<List<UserModel>> GetAllUsers();
        Task<UserModel> GetById(int id);
        Task<UserModel> Register(UserModel userModel);
        Task<UserModel> Update(UserModel userModel, int id);
        Task<bool> Delete(int id);
    }
}
