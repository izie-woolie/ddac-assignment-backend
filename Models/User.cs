namespace DDACAssignment.Models
{
    public class User
    {
        // User Data
        public Guid Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string Role { get; set; } = "User";
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // JWT Authentication
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }

        public Player? PlayerProfile { get; set; }
        public Organizer? OrganizerProfile { get; set; }
        public Personnel? PersonnelProfile { get; set; }
    }
}
