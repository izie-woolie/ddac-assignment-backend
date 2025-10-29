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

            modelBuilder.Entity<User>()
                .HasOne(u => u.PlayerProfile)
                .WithOne(p => p.User)
                .HasForeignKey<Player>(p => p.UserId)
                .IsRequired(false);


            modelBuilder.Entity<User>()
                .HasOne(u => u.PersonnelProfile)
                .WithOne(p => p.User)
                .HasForeignKey<Personnel>(p => p.UserId)
                .IsRequired(false);

            modelBuilder.Entity<User>()
                .HasOne(u => u.OrganizerProfile)
                .WithOne(p => p.User)
                .HasForeignKey<Organizer>(o => o.UserId)
                .IsRequired(false);


            modelBuilder.Entity<Match>()
                .HasOne(m => m.Schedule)
                .WithOne(s => s.Matches)
                .HasForeignKey<Schedule>(s => s.MatchId)
                .IsRequired(false);

            modelBuilder.Entity<Player>()
                .HasOne(p => p.PlayerPerformance)
                .WithOne(pp => pp.Player)
                .HasForeignKey<PlayerPerformance>(pp => pp.PlayerId);

            modelBuilder.Entity<Team>()
                .HasOne(t => t.TeamStatistic)
                .WithOne(ts => ts.Team)
                .HasForeignKey<TeamStatistic>(ts => ts.TeamId);

            modelBuilder.Entity<Match>()
                .HasMany(m => m.Rounds)
                .WithOne(r => r.Match)
                .HasForeignKey(r => r.MatchId);

            modelBuilder.Entity<Team>()
                .HasMany(t => t.Personnel)
                .WithOne(p => p.Team)
                .HasForeignKey(p => p.TeamId);

            modelBuilder.Entity<Team>()
                .HasMany(t => t.Player)
                .WithOne(p => p.Team)
                .HasForeignKey(p => p.TeamId);

            modelBuilder.Entity<Organizer>()
                .HasMany(o => o.Tournament)
                .WithOne(t => t.Organizer)
                .HasForeignKey(t => t.OrganizerId);

        }
    }

}
