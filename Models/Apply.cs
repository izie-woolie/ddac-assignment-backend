namespace DDACAssignment.Models
{
    public class Apply
    {
        public Guid Id { get; set; }
        public string RequestedRole { get; set; } = string.Empty;
        public string Status { get; set; } = "Pending";
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
