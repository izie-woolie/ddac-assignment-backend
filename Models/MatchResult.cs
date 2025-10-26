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

    }
}
