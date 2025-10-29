namespace DDACAssignment.Models
{
    public class Team
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = null!;
        public DateTime CreatedAt { get; set; }

        public TeamStatistic? TeamStatistic { get; set; }

        public ICollection<Personnel> Personnel { get; set; } = [];

        public ICollection<Player> Player { get; set; } = [];

        public ICollection<Tournament> Tournaments { get; set; } = [];
    }
}
