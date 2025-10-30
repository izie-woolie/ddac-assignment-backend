using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDACAssignment.Controllers
{
    [Route("api/personnels")]
    [ApiController]
    public class PersonnelsController : ControllerBase
    {
        [HttpGet("me")]
        public string GetMe()
        {
            return "Get me";
        }

        [HttpPatch("me")]
        public string UpdateMe()
        {
            return "Update Me";
        }

        [HttpGet("pending-players")]
        public string GetPendingPlayers()
        {
            return "Get pending players";
        }

        [HttpPost("approve-player")]
        public string ApprovePlayer()
        {
            return "Approve player";
        }

        [HttpDelete("reject-player")]
        public string RejectPlayer()
        {
            return "Reject Player";
        }

        [HttpPost("teams")]
        public string CreateTeam()
        {
            return "Create Team";
        }

        [HttpGet("teams")]
        public string GetTeam()
        {
            return "Get Team";
        }

        [HttpPatch("teams/{id}")]
        public string UpdateTeamsInfo(Guid id)
        {
            return $"Update Teams Info {id}";
        }

        [HttpPost("teams/{id}/add-player/{playerId}")]
        public string AddPlayerToTeam(Guid id, Guid playerId)
        {
            return $"Add player to team: {id} and {playerId}";
        }

        [HttpDelete("teams/{id}/remove-player/{playerId}")]
        public string RemovePlayerFromTeam(Guid id, Guid playerId)
        {
            return $"Remove player from team: {id} and {playerId}";
        }

        // TODO: I am not sure about this flow actually
        [HttpPatch("matches/{matchId}/status")]
        public string UpdateMatchStatus(Guid matchId)
        {
            return $"Update match status {matchId}";
        }

        [HttpPatch("matches/{matchId}/submit-result")]
        public string SubmitResult(Guid matchId)
        {
            return $"Submit result {matchId}";
        }
    }
}
