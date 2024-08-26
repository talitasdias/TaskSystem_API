using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskSystem_API.Models;
using TaskSystem_API.Repositories.Interfaces;

namespace TaskSystem_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<UserModel>>> GetAllUsers()
        {
            List<UserModel> users = await _userRepository.GetAllUsers();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<UserModel>>> GetById(int id)
        {
            UserModel user = await _userRepository.GetById(id);
            return Ok(user);
        }
    }
}
