using DDACAssignment.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDACAssignment.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly DDACDbContext _context;
        public UsersController(DDACDbContext context) => _context = context;

        [HttpPost("register")]
        public string Register()
        {
            return "register";
        }

        [HttpPost("login")]
        public string Login()
        {
            return "login";
        }

        [HttpGet("me")]
        public string Me()
        {
            return "me";
        }


        [HttpPost("apply/organizer")]
        public string ApplyOrganizer()
        {
            return "apply organizer";
        }

        [HttpPost("apply/personnel")]
        public string ApplyPersonnel()
        {
            return "apply personnel";
        }

        [HttpPost("apply/player")]
        public string ApplyPlayer()
        {
            return "apply player";
        }
    }
}
