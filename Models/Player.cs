namespace DDACAssignment.Models
{
    public class Player
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Position { get; set; } = null!;
        public DateTime JoinedAt { get; set; } = DateTime.UtcNow;
    }
}
