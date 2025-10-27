using System.ComponentModel.DataAnnotations;

namespace DDACAssignment.Models
{
    public class PlayerPerformance
    {
        [Key]
        public Guid PlayerId { get; set; }
        public int TotalMatches { get; set; }
        public int TotalKills { get; set; }
        public int TotalDeaths { get; set; }
        public int TotalAssists { get; set; }
        public int TotalScore { get; set; }
        public int TotalMvp { get; set; }
        public decimal WinRate { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Player Player { get; set; } = null!;

    }
}
