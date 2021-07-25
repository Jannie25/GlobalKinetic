using GlobalKinetic.Models.General;
using GlobalKinetic.Models.Requests;

namespace GlobalKinetic.Repository.Interfaces
{
    public interface IUserRepository
    {
        bool InsertUser(RegisterRequest model);
        User GetUser(AuthenticateRequest model);
    }
}
