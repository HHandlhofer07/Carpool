using Carpool.Shared.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Carpool.Client.Services
{
    public class AuthService
    {
        private readonly HttpClient _http;

        public AuthService(HttpClient http)
        {
            _http = http;
        }

        public async Task<AuthResponse> Login(LoginRequest request)
        {
            var response = await _http.PostAsJsonAsync("api/auth/login", request);
            return await response.Content.ReadFromJsonAsync<AuthResponse>();
        }
    }
}
