using Microsoft.EntityFrameworkCore;
using TaskSystem_API.Data;
using TaskSystem_API.Models;
using TaskSystem_API.Repositories.Interfaces;

namespace TaskSystem_API.Repositories
{
    public class TaskRepository : ITaskRepository
    {

        private readonly TaskSystemDBContext _dbContext;
        public TaskRepository(TaskSystemDBContext TaskSystemDBContext)
        {
            _dbContext = TaskSystemDBContext;
        }
        public async Task<TaskModel> Add(TaskModel task)
        {
            await _dbContext.Tasks.AddAsync(task);
            await _dbContext.SaveChangesAsync();

            return task;
        }

        public async Task<bool> Delete(int id)
        {
            TaskModel taskById = await GetById(id);

            if (taskById == null)
            {
                throw new Exception($"User with ID: {id} was not found in the database.");
            }

            _dbContext.Tasks.Remove(taskById);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public Task<List<TaskModel>> GetAllTasks()
        {
            throw new NotImplementedException();
        }

        public Task<TaskModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TaskModel> Update(TaskModel tarefa, int id)
        {
            throw new NotImplementedException();
        }
    }
}
