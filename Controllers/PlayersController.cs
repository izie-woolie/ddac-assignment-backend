using System.Dynamic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDACAssignment.Controllers
{
    [Route("api/players")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        [HttpGet("me")]
        public string GetMe()
        {
            return "GetMe";
        }

        [HttpGet("matches")]
        public string GetMatches()
        {
            return "Get matches";
        }

        [HttpGet("stats")]
        public string GetStats()
        {
            return "Get stats";
        }

        [HttpPost("join/{teamId}")]
        public string RequestJoin(Guid teamId)
        {
            return $"Join team {teamId}";
        }
    }
}
