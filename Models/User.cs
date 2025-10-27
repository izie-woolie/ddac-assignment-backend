namespace DDACAssignment.Models
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string Type { get; set; } = null!;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Player? PlayerProfile { get; set; }
        public Organizer? OrganizerProfile { get; set; }
        public Personnel? PersonnelProfile { get; set; }
    }
}
