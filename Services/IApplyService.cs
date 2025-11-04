using DDACAssignment.Dtos.Request;

namespace DDACAssignment.Services
{
    public interface IApplyService
    {
        string? ApplyOrganizerAsync(ApplyOrganizerDto request);
        string? ApplyTeamAsync(string? request);
    }
}
