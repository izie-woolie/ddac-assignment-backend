namespace DDACAssignment.Models
{
    public class PlayerMatchStat
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Assists { get; set; }
        public int Score { get; set; }
        public bool Mvp { get; set; } = false;

        public Guid MatchId { get; set; }
        public Match Match { get; set; } = null!;

        public Guid PlayerId { get; set; }
        public Player Player { get; set; } = null!;

        public Guid TeamId { get; set; }
        public Team Team { get; set; } = null!;
    }
}
