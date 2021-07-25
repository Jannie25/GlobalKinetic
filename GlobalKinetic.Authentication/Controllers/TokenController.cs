using GlobalKinetic.JWTHelper.Interfaces;
using GlobalKinetic.JWTHelper.Models;
using GlobalKinetic.JWTHelper.Services;
using GlobalKinetic.Models.General;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace GlobalKinetic.Authentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private IOptions<JWTConfig> _jwtconfig;

        public TokenController(IOptions<JWTConfig> jwtconfig)
        {
            _jwtconfig = jwtconfig;
        }

        [AllowAnonymous]
        [HttpPost("gettoken")]
        public string GetToken(User user)
        {
            var jwt = new JwtService(_jwtconfig);
            var token = jwt.GenerateSecurityToken(user);
            return token;
        }
    }
}
