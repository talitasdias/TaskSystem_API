using TaskSystem_API.Models;
using TaskSystem_API.Repositories.Interfaces;
using TaskSystem_API.Services.Interfaces;

namespace TaskSystem_API.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;
        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }
        public Task<bool> Delete(int id)
        {
            return _taskRepository.Delete(id);
        }

        public Task<TaskModel> GetById(int id)
        {
            return _taskRepository.GetById(id);
        }

        public Task<List<TaskModel>> ListAll()
        {
            return _taskRepository.GetAllTasks();
        }

        public Task<TaskModel> Register(TaskModel taskModel)
        {
            throw new NotImplementedException();
        }

        public Task<TaskModel> Update(TaskModel newTask, int id)
        {
            throw new NotImplementedException();
        }
    }
}
