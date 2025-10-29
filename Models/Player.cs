namespace DDACAssignment.Models
{
    public class Player
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Position { get; set; } = null!;
        public DateTime JoinedAt { get; set; } = DateTime.UtcNow;

        public Guid UserId { get; set; }
        public User User { get; set; } = null!;

        public PlayerPerformance? PlayerPerformance { get; set; }

        public Guid TeamId { get; set; }
        public Team Team { get; set; } = null!;
    }
}
