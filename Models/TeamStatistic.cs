namespace DDACAssignment.Models
{
    public class TeamStatistic
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int TotalTournaments { get; set; }
        public int TotalMatches { get; set; }
        public int TotalWins { get; set; }
        public int TotalLosses { get; set; }
        public int TotalDraws { get; set; }
        public decimal WinRate { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
