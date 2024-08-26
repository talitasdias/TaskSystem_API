using TaskSystem_API.Models;
using TaskSystem_API.Repositories.Interfaces;

namespace TaskSystem_API.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        public Task<TaskModel> Add(TaskModel tarefa)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
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
