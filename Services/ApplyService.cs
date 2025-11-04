using DDACAssignment.Dtos.Request;

namespace DDACAssignment.Services
{
    public class ApplyService : IApplyService
    {
        public string? ApplyOrganizerAsync(ApplyOrganizerDto request)
        {
            if (request is null)
                return null;

            return request.OrganizationName.ToString();
        }

        public string? ApplyTeamAsync(string? request)
        {
            throw new NotImplementedException();
        }
    }
}
