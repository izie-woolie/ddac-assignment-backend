namespace DDACAssignment.Models.Request
{
    public abstract class Request
    {
        public Guid Id { get; set; }
        public Guid Requested { get; set; }
        public string Status { get; set; } = "Pending";
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
