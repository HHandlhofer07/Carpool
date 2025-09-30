namespace Carpool.Shared.Models
{
    public class AuthResponse
    {
        public string Token { get; set; }
        public bool IsAuthSuccessful { get; set; }
        public string ErrorMessage { get; set; }
    }
}
