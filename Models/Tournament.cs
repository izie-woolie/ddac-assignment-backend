namespace DDACAssignment.Models
{
    public class Tournament
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Type { get; set; } = null!;
        public string Status { get; set; } = null!;

        public Guid OrganizerId { get; set; }
        public Organizer Organizer { get; set; } = null!;

        public ICollection<Match> Matches { get; set; } = [];

        public ICollection<TournamentResult> TournamentResults { get; set; } = [];

        public ICollection<Team> Teams { get; set; } = [];



    }
}
