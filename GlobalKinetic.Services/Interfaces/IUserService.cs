using GlobalKinetic.Models.Requests;
using GlobalKinetic.Models.Responses;

namespace GlobalKinetic.Services.Interfaces
{
    public interface IUserService
    {
        bool Register(RegisterRequest model);
        AuthenticateResponse Authenticate(AuthenticateRequest model);
    }
}
