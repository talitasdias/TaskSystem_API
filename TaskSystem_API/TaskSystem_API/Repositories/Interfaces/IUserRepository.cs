using TaskSystem_API.Models;

namespace TaskSystem_API.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<List<UserModel>> GetAllUsers();
        Task<UserModel> GetById(int id);
        Task<UserModel> Add(UserModel user);
        Task<UserModel> Uptade(UserModel user, int id);
        Task<bool> Delete(int id);
    }
}
