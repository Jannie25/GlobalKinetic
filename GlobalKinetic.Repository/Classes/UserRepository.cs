using GlobalKinetic.DataHelper.Interfaces;
using GlobalKinetic.Models.General;
using GlobalKinetic.Models.Requests;
using GlobalKinetic.Repository.Interfaces;

namespace GlobalKinetic.Repository.Classes
{
    public class UserRepository : IUserRepository
    {
        private IDapperService _dapperService;

        public UserRepository(IDapperService dapperService)
        {
            _dapperService = dapperService;
        }

        public bool InsertUser(RegisterRequest model)
        {
            var p = new
            {
                model.Username,
                model.Password,
                model.Email,
                model.FirstName,
                model.LastName
            };
            
            var result = _dapperService.Execute("usp_InsertUser", p);

            return (result > 0);
        }

        public User GetUser(AuthenticateRequest model)
        {
            var p = new 
            {
                model.Username,
                model.Password 
            };
            return _dapperService.QuerySingle<User>("usp_GetUser", p);
        }
    }
}
