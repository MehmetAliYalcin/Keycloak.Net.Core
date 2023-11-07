using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using User.API.Models.DTOs;
using User.API.Services.Abstract;

namespace User.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [Authorize]
        [HttpDelete("{userId}")]
        public async Task<IActionResult> DeleteUser(string userId)
        {
            var result = await _userService.DeleteUserAsync(userId);

            if(result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLoginDto userLoginDto)
        {
            var result = await _userService.LoginUserAsync(userLoginDto);

            if(result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddUser(CreateUserDto createUserDto)
        {
            var result = await _userService.AddUserAsync(createUserDto);

            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateUser(UpdateUserDto updateUserDto)
        {
            var result = await _userService.UpdateUserAsync(updateUserDto);

            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }
    }
}
