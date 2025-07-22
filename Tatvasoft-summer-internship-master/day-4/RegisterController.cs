using Microsoft.AspNetCore.Mvc;
using Mission.Api.Models;
using Mission.Entities.Entities;
using Mission.Entities.context;

namespace Mission.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegisterController : ControllerBase
    {
        private readonly MissionDbContext _context;

        public RegisterController(MissionDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Register([FromBody] RegisterRequest request)
        {
            if (_context.Users.Any(u => u.EmailAddress == request.EmailAddress))
            {
                return BadRequest("Email already exists.");
            }

            var user = new User
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                EmailAddress = request.EmailAddress,
                Password = request.Password, // In production, hash the password!
                PhoneNumber = request.PhoneNumber,
                UserType = request.UserType,
                UserImage = request.UserImage ?? string.Empty,
                CreatedDate = DateTime.UtcNow,
                ModifiedDate = DateTime.UtcNow,
                IsDeleted = false
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            return Ok("Registration successful.");
        }

        [HttpGet]
        [Route("Test")]
        public IActionResult Test()
        {
            return Ok("Test endpoint is working");
        }
    }
}

