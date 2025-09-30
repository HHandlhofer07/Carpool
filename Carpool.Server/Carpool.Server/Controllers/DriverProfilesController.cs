using Carpool.Server.Data;
using Carpool.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Carpool.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverProfilesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DriverProfilesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<DriverProfile>> Get()
        {
            return await _context.DriverProfiles.ToListAsync();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Post(DriverProfile profile)
        {
            _context.DriverProfiles.Add(profile);
            await _context.SaveChangesAsync();
            return Ok(profile);
        }
    }
}
