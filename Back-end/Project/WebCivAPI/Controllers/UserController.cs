using Application.Services;
using Entities.Classes;
using Entities.Interfaces;
using Microsoft.AspNetCore.Mvc;
using WebCivAPI.Contracts;

namespace WebCivAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<UserResponse>> GetUsers()
        {
            var users = await _userService.GetAllUsers();
            var response = users.Select(u => new UserResponse(u.id, u.login, u.hPassword, u.email, u.isAdmin));
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> CreateUser([FromBody] UserRequest request) 
        {
            var (user, error) = Entities.Classes.User.CreateNewUser(Guid.NewGuid(), request.login, request.password, request.email, false);

            if (!string.IsNullOrEmpty(error))
            {
                return BadRequest(error);
            }
            else
            {
                await _userService.CreateUser(user);
                return Ok(user.id);
            }
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<Guid>> AdminUpdateUser(Guid id, [FromBody] UserRequestAdmin request)
        {
            await _userService.UpdateUser(id, request.login, request.email, request.isAdmin);

            return Ok(id);
        }
    }
}
