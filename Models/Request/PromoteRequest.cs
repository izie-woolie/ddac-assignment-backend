namespace DDACAssignment.Models.Request
{
    public class PromoteRequest : Request
    {
        public string RequestedRole { get; set; } = string.Empty;

        public string TeamName { get; set; } = string.Empty;
    }
}
