using TaskSystem_API.Models;

namespace TaskSystem_API.Repositories.Interfaces
{
    public interface ITaskRepository
    {
        Task<List<TaskModel>> GetAllTasks();
        Task<TaskModel> GetById(int id);
        Task<TaskModel> Add(TaskModel task);
        Task<TaskModel> Update(TaskModel newTask, TaskModel task, int id);
        Task<bool> Delete(int id);
    }
}
