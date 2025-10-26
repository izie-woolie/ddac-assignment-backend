namespace DDACAssignment.Models
{
    public class Match
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public String Status { get; set; } = null!;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
