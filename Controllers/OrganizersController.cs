using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDACAssignment.Controllers
{
    [Route("api/organizers")]
    [ApiController]
    public class OrganizersController : ControllerBase
    {
        [HttpGet("me")]
        public string Me()
        {
            return "me";
        }

        [HttpPatch("me")]
        public string UpdateMe()
        {
            return "me";
        }

        [HttpPost("tournaments")]
        public string CreateTournaments()
        {
            return "tournament";
        }

        [HttpGet("tournaments")]
        public string GetTournaments()
        {
            return "tournament";
        }

        [HttpPatch("tournaments/{id}")]
        public string UpdateTournaments(Guid id)
        {
            return $"Update tournaments {id}";
        }

        [HttpPost("tournaments/{id}/start")]
        public string StartTournament(Guid id)
        {
            return $"Start Tournament {id}";
        }


        [HttpPost("tournaments/{id}/end")]
        public string EndTournament(Guid id)
        {
            return $"End Tournament {id}";
        }

        [HttpDelete("tournaments/{id}")]
        public string CancelTournament(Guid id)
        {
            return "cancelling tournament";
        }

        [HttpPost("tournaments/{tournamentId}/matches")]
        public string CreateMatches()
        {
            return "Create Matches";
        }

        [HttpGet("tournaments/{tournamentId}/matches")]
        public string GetMatches(Guid tournamentId)
        {
            return $"Create Matches: {tournamentId}";
        }

        [HttpPatch("matches/{matchId}/results")]
        public string UpdateMatchResults(Guid matchId)
        {
            return $"Uodate Match Results {matchId}";
        }

        [HttpPost("matches/{matchId}/rounds")]
        public string AddRound(Guid matchId)
        {
            return $"Add round {matchId}";
        }

        [HttpPost("matches/{matchId}/schedule")]
        public string AddSchedule(Guid matchId)
        {
            return $"Add Schedule {matchId}";
        }
    }
}
