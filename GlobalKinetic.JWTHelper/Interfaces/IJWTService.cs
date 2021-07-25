using GlobalKinetic.Models.General;

namespace GlobalKinetic.JWTHelper.Interfaces
{
    public interface IJWTService
    {
        string GenerateSecurityToken(User user);
    }
}
