using Microsoft.AspNetCore.Mvc;
using Carpool.Shared;

namespace Carpool.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private static List<User> Users = new List<User>(); // vorerst ohne DB

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            if (!user.Email.EndsWith("@josephinum.at"))
                return BadRequest("Nur @josephinum.at Schüler erlaubt.");

            Users.Add(user);
            return Ok(user);
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] User login)
        {
            var u = Users.FirstOrDefault(x => x.Email == login.Email && x.PasswordHash == login.PasswordHash);
            if (u == null) return Unauthorized();
            return Ok(u);
        }
    }
}
