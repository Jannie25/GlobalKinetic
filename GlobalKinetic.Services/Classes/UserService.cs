using GlobalKinetic.JWTHelper.Interfaces;
using GlobalKinetic.Models.General;
using GlobalKinetic.Models.Requests;
using GlobalKinetic.Models.Responses;
using GlobalKinetic.Repository.Interfaces;
using GlobalKinetic.Services.Interfaces;

namespace GlobalKinetic.Services.Classes
{
    public class UserService : IUserService
    {
        private IJWTService _jwtService;
        private IUserRepository _userRepository;

        public UserService(IJWTService jwtService, IUserRepository userRepository)
        {
            _jwtService = jwtService;
            _userRepository = userRepository;
        }

        public bool Register(RegisterRequest model)
        {
            return _userRepository.InsertUser(model);
        }

        public AuthenticateResponse Authenticate(AuthenticateRequest model)
        {
            var user = _userRepository.GetUser(model);

            if (user == null) return null;

            // authentication successful so generate jwt token
            var token = _jwtService.GenerateSecurityToken(user);

            return new AuthenticateResponse
            {
                UserId = user.UserId,
                UserName = user.Username,
                UserToken = token
            };
        }
    }
}