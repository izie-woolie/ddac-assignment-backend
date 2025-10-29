namespace DDACAssignment.Models
{
    public class TournamentResult
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Placement { get; set; } = null!;
        public int TotalScore { get; set; }
        public int TotalWins { get; set; }
        public int TotalLosses { get; set; }

        public Guid TournamentId { get; set; }
        public Tournament Tournament { get; set; } = null!;

        public Guid TeamId { get; set; }
        public Team Team { get; set; } = null!;
    }
}
