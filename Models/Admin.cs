using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDACAssignment.Models
{
    public class Admin
    {
        [Key, ForeignKey("User")]
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public User User { get; set; } = null!;
    }
}
