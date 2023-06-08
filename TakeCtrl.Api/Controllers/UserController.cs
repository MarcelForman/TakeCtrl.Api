using Microsoft.AspNetCore.Mvc;
using TakeCtrl.Api.Entities;
using TakeCtrl.Api.Models.Dtos;
using TakeCtrl.Api.Repositories;
using TakeCtrl.Api.Repositories.Contracts;

namespace TakeCtrl.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<User>> GetUser(User user)
        {
            throw new NotImplementedException();
        }

        [HttpPost("login")]
        public async Task<ActionResult<bool>> LoginUser(LoginDto user)
        {
            var loginUser = await _userRepository.LoginUser(user);

            if (loginUser)
            {
                return StatusCode(StatusCodes.Status200OK, "Logged in");
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occured.");
            }
            //return Ok(loginUser);
        }
    }
}
