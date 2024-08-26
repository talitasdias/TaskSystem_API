using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskSystem_API.Models;
using TaskSystem_API.Repositories.Interfaces;

namespace TaskSystem_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskRepository _taskRepository;
        public TaskController(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<TaskModel>>> listAll()
        {
            List<TaskModel> tasks = await _taskRepository.GetAllTasks();
            return Ok(tasks);
        }
    }
}
