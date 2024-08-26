using TaskSystem_API.Data;
using TaskSystem_API.Models;
using TaskSystem_API.Repositories.Interfaces;

namespace TaskSystem_API.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly TaskSystemDBContext _dbContext;
        public UserRepository(TaskSystemDBContext TaskSystemDBContext)
        {
            _dbContext = TaskSystemDBContext;
        }
        public async Task<UserModel> Add(UserModel user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();

            return user;
        }

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

        public Task<UserModel> Uptade(UserModel user, int id)
        {
            throw new NotImplementedException();
        }
    }
}
