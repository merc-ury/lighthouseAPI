using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LighthouseAPI.Models;
using LighthouseAPI.Services;

namespace LighthouseAPI
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("get/all")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _userService.GetAllUsers());
        }

        [HttpGet("get/{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            return Ok(await _userService.GetUserByID(id));
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddUser(User user)
        {
            return Ok(await _userService.AddUser(user));
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateUser(User user)
        {
            return Ok(await _userService.UpdateUser(user));
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            return Ok(await _userService.DeleteUser(id));
        }
    }
}