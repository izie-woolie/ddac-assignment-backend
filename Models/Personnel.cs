namespace DDACAssignment.Models
{
    public class Personnel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Role { get; set; } = null!;
        public DateTime JoinedAt { get; set; } = DateTime.UtcNow;

        public Guid UserId { get; set; }
        public User User { get; set; } = null!;

        public Guid TeamId { get; set; }
        public Team Team { get; set; } = null!;
    }
}
