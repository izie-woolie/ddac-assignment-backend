namespace DDACAssignment.Models
{
    public class PlayerPerformance
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int TotalMatches { get; set; }
        public int TotalKills { get; set; }
        public int TotalDeaths { get; set; }
        public int TotalAssists { get; set; }
        public int TotalScore { get; set; }
        public int TotalMvp { get; set; }
        public decimal WinRate { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
