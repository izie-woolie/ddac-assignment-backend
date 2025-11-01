using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDACAssignment.Models
{
    public class Player
    {
        [Key, ForeignKey("User")]
        public Guid Id { get; set; }
        public string Position { get; set; } = string.Empty;
        public DateTime JoinedAt { get; set; } = DateTime.UtcNow;

        public PlayerPerformance? PlayerPerformance { get; set; }

        public User User { get; set; } = null!;

        public Guid TeamId { get; set; }
        public Team Team { get; set; } = null!;
    }
}
