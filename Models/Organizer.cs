namespace DDACAssignment.Models
{
    public class Organizer
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string OrganizationName { get; set; } = null!;
        public DateTime JoinedAt { get; set; } = DateTime.UtcNow;

        public Guid UserId { get; set; }
        public User User { get; set; } = null!;

        public ICollection<Tournament> Tournament = [];
    }
}
