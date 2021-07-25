namespace GlobalKinetic.JWTHelper.Models
{
    public class JWTConfig
    {
        public string Secret { get; set; }
        public int ExpirationInMinutes { get; set; }
    }
}
