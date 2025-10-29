namespace DDACAssignment.Models
{
    public class MatchResult
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Result { get; set; } = null!;
        public int Score { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Assists { get; set; }


        public Guid MatchId { get; set; }
        public Match Match { get; set; } = null!;

        public Guid TeamId { get; set; }
        public Team Team { get; set; } = null!;
    }
}
