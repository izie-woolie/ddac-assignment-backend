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

    }
}
