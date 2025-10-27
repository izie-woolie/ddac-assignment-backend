namespace DDACAssignment.Models
{
    public class Personnel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Role { get; set; } = null!;
        public DateTime JoinedAt { get; set; } = DateTime.UtcNow;

        public Guid UserId { get; set; } = Guid.NewGuid();
        public User User { get; set; } = null!;
    }
}
