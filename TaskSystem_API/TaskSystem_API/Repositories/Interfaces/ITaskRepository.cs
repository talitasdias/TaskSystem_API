using TaskSystem_API.Models;

namespace TaskSystem_API.Repositories.Interfaces
{
    public interface ITaskRepository
    {
        Task<List<TaskModel>> GetAllTasks();
        Task<TaskModel> GetById(int id);
        Task<TaskModel> Add(TaskModel tarefa);
        Task<TaskModel> Update(TaskModel tarefa, int id);
        Task<bool> Delete(int id);
    }
}
