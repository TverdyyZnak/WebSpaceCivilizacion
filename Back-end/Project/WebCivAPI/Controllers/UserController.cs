using Application.Services;
using Entities.Classes;
using Entities.Interfaces;
using Microsoft.AspNetCore.Mvc;
using WebCivAPI.Contracts.UsersContracts;

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

        [HttpGet("All")]
        public async Task<ActionResult<UserResponse>> GetUsers()
        {
            var users = await _userService.GetAllUsers();
            var response = users.Select(u => new UserResponse(u.id, u.login, u.hPassword, u.email, u.isAdmin));
            return Ok(response);
        }

        [HttpGet("ById")]
        public async Task<ActionResult<UserResponse>> GetUserById(Guid id)
        {
            var user = await _userService.GetUserById(id);
            return Ok(user);
        }

        [HttpGet("ByLogin")]
        public async Task<ActionResult<UserResponse>> GetUserByLogin(string login)
        {
            var user = await _userService.GetUserByLogin(login);
            if (user == null) 
            {
                return BadRequest("Пользователя с данным логином нет");
            }
            return Ok(user);
        }


        [HttpPost]
        public async Task<ActionResult<Guid>> CreateUser([FromBody] UserRequest request) 
        {
            var userInDB = await _userService.GetUserByLogin(request.login);
            if(userInDB != null)
            {
                return BadRequest("A user with this login already exists; "); 
            }

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

        [HttpPost("Login")]
        public async Task<ActionResult<string>> Login([FromBody] AuthRequest auth)
        {
            return Ok(await _userService.Login(auth.login, auth.password));
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<Guid>> AdminUpdateUser(Guid id, [FromBody] UserRequestAdmin request)
        {
            await _userService.UpdateUser(id, request.login, request.email, request.isAdmin);

            return Ok(id);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<Guid>> DeleteUserById(Guid id)
        {
            await _userService.DeleteUser(id);
            return Ok(id);
        }
    }
}
