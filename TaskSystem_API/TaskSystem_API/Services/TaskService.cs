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
            return _taskRepository.Add(taskModel);
        }

        public async Task<TaskModel> Update(TaskModel taskModel, int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("The ID must be greater than 0.", nameof(id));
            }

            TaskModel taskById = await _taskRepository.GetById(id);

            if (taskById == null)
            {
                throw new KeyNotFoundException($"No task found with the ID {id}.");
            }

            taskModel.Id = id;
            return await _taskRepository.Update(taskModel, id);
        }
    }
}
