using DDACAssignment.Models;
using Microsoft.EntityFrameworkCore;

namespace DDACAssignment.Data
{
    public class DDACDbContext : DbContext
    {
        public DDACDbContext(DbContextOptions<DDACDbContext> options) : base(options) { }

        public DbSet<User> Users => Set<User>();

        public DbSet<Player> Players => Set<Player>();
        public DbSet<Personnel> Personnels => Set<Personnel>();
        public DbSet<Organizer> Organizers => Set<Organizer>();

        public DbSet<Team> Teams => Set<Team>();
        public DbSet<Tournament> Tournaments => Set<Tournament>();
        public DbSet<Match> Matches => Set<Match>();
        public DbSet<Round> Rounds => Set<Round>();
        public DbSet<Schedule> Schedules => Set<Schedule>();

        public DbSet<TournamentResult> TournamentResults => Set<TournamentResult>();
        public DbSet<MatchResult> MatchResults => Set<MatchResult>();
        public DbSet<PlayerMatchStat> PlayerMatchStats => Set<PlayerMatchStat>();

        public DbSet<TeamStatistic> TeamStatistics => Set<TeamStatistic>();
        public DbSet<PlayerPerformance> PlayerPerformances => Set<PlayerPerformance>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

}
