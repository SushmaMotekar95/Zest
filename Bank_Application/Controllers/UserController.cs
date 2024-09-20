using Bank_Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bank_Application.Models;
namespace Bank_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        public async Task<ActionResult<User>> Createuser(User user)
        {
            var createdUser = await _userService.CreateUser(user);
            return CreatedAtAction(nameof(GetUserById), new { id = createdUser.Id }, createdUser);

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<User>>  GetUserById(int id)
        {
            var user = await _userService.GetUserByID(id);
            if (user == null)
            {
                return NotFound();
            }
            return user;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetAllUsers()
        {
            var users = await _userService.GetAllUser();
            return Ok(users);
        }
      }
}
