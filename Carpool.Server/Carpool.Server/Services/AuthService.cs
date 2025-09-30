using Carpool.Server.Data;
using Carpool.Shared.Models;
using Microsoft.AspNetCore.Identity;

namespace Carpool.Server.Services
{
    public class AuthService
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public AuthService(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
    }
}
