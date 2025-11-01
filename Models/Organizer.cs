using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDACAssignment.Models
{
    public class Organizer
    {
        [Key, ForeignKey("User")]
        public Guid Id { get; set; }
        public string OrganizationName { get; set; } = string.Empty;
        public DateTime JoinedAt { get; set; } = DateTime.UtcNow;


        public User User { get; set; } = null!;

        public ICollection<Tournament> Tournament = [];
    }
}
