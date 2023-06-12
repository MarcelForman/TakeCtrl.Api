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

/*        [HttpGet]
        public async Task<ActionResult<User>> GetUser(User user)
        {
            throw new NotImplementedException();

        }*/

        [HttpPost("login")]
        public async Task<ActionResult<User>> LoginUser(LoginDto user)
        {
            var loginUser = await _userRepository.LoginUser(user);

        
            if (loginUser != null)
            {
                //return StatusCode(StatusCodes.Status200OK, "Logged in");
                return Ok(loginUser);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("/api/users")]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var users = await _userRepository.GetUsers();

            if (users != null)
            {
                return Ok(users);
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occured.");
            }
        }

        [HttpPost("adduser")]
        public async Task<ActionResult> AddUser(User user)
        {
            var newUser = await _userRepository.AddUser(user);

            if (newUser != null)
            {
                return Ok(newUser);
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occured");
            }
        }

        [HttpPost("feedback")]
        public async Task<ActionResult> PostFeedback(Feedback feedback)
        {
            var newUser = await _userRepository.PostFeedback(feedback);

            if (newUser != null)
            {
                return Ok(newUser);
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occured");
            }
        }

        [HttpGet("getfeedback")]
        public async Task<ActionResult<IEnumerable<Feedback>>> GetAllFeedback()
        {
            var result = await _userRepository.GetAllFeedbacks();

            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occured");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<User>> DeleteUser(int id)
        {
            var result = await _userRepository.DeleteUser(id);

            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occured");
            }

        }

    }
}
