using DDACAssignment.Dtos.Request;
using DDACAssignment.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDACAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController(IApplyService applyService) : ControllerBase
    {
        [HttpPost("apply/organizer")]
        public string ApplyOrganizer(ApplyOrganizerDto request)
        {
            return applyService.ApplyOrganizerAsync(request)!;
        }
    }
}
