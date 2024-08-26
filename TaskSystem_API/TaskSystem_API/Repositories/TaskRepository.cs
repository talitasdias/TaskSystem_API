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

        public async Task<List<TaskModel>> GetAllTasks()
        {
            return await _dbContext.Tasks
                .Include(x => x.User)
                .ToListAsync();
        }

        public async Task<TaskModel> GetById(int id)
        {
            return await _dbContext.Tasks
                .Include(x => x.User)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<TaskModel> Update(TaskModel tarefa, int id)
        {
            TaskModel taskById = await GetById(id);

            if (taskById == null)
            {
                throw new Exception($"Tarefa para o ID {id} não foi encontrado no banco de dados.");
            }

            taskById.Name = tarefa.Name;
            taskById.Description = tarefa.Description;
            taskById.Status = tarefa.Status;
            taskById.UserId = tarefa.UserId;

            _dbContext.Tasks.Update(taskById);
            await _dbContext.SaveChangesAsync();

            return taskById;
        }
    }
}
