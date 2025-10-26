using DDACAssignment.Data;
using DDACAssignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDACAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DDACDbContext _context;

        public UserController(DDACDbContext context) => _context = context;

        [HttpGet]
        public IActionResult GetAll() => Ok(_context.Users.ToList());

        [HttpPost]
        public IActionResult Create([FromBody] User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return Ok(user);
        }

    }
}
