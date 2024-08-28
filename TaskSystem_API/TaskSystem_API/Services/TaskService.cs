﻿using TaskSystem_API.Models;
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
            throw new NotImplementedException();
        }

        public Task<TaskModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TaskModel>> ListAll()
        {
            throw new NotImplementedException();
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
