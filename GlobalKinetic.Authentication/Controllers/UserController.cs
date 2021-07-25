using GlobalKinetic.Models.Requests;
using GlobalKinetic.Models.Responses;
using GlobalKinetic.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GlobalKinetic.Authentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public IActionResult Register(RegisterRequest model)
        {
            var response = _userService.Register(model);

            if (!response)
                return BadRequest(new { message = "Error in registering user" });

            return Ok(response);
        }

        [AllowAnonymous]
        [HttpGet("authenticate")]
        public AuthenticateResponse Authenticate(string userName, string password)
        {
            AuthenticateRequest model = new AuthenticateRequest { Username = userName, Password = password };
            return _userService.Authenticate(model);

            //if (response == null)
            //    return BadRequest(new { message = "Username or password is incorrect" });

            //return Ok(response);
        }
    }
}
