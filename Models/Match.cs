namespace DDACAssignment.Models
{
    public class Match
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public String Status { get; set; } = null!;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Schedule? Schedule { get; set; }

        public ICollection<Round> Rounds { get; set; } = [];

        public Guid TournamentId { get; set; }
        public Tournament Tournament { get; set; } = null!;

        public ICollection<PlayerMatchStat> PlayerMatchStats { get; set; } = [];
        public ICollection<MatchResult> MatchResults { get; set; } = null!;
    }
}
