using TaskSystem_API.Models;

namespace TaskSystem_API.Services.Interfaces
{
    public interface ITaskService
    {
        Task<List<TaskModel>> ListAll();
        Task<TaskModel> GetById(int id);
        Task<TaskModel> Register(TaskModel taskModel);
        Task<TaskModel> Update(TaskModel newTask, int id);
        Task<bool> Delete(int id);
    }
}
