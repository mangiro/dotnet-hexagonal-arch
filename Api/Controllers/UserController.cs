using Api.Filters;
using Domain.Entities;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService) =>
            _userService = userService;

        [HttpGet]
        public async Task<IActionResult> RecoverUsers([FromQuery] PaginationFilter filters)
        {
            var users = await _userService.GetUsers(filters.PageNumber, filters.PageSize);
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> RecoverUser(Guid id)
        {
            var user = await _userService.GetUser(id);
            if (user is null) {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            await _userService.CreateUser(user);

            return StatusCode(201);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            await _userService.RemoveUser(id);

            return NoContent();
        }
    }
}
