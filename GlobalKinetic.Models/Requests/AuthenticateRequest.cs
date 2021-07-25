using System.ComponentModel.DataAnnotations;

namespace GlobalKinetic.Models.Requests
{
    public class AuthenticateRequest
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
