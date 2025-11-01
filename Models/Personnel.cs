using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDACAssignment.Models
{
    public class Personnel
    {
        [Key, ForeignKey("User")]
        public Guid Id { get; set; }
        public string Role { get; set; } = string.Empty;
        public DateTime JoinedAt { get; set; } = DateTime.UtcNow;

        public Guid TeamId { get; set; }
        public Team Team { get; set; } = null!;
    }
}
