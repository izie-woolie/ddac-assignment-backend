using DDACAssignment.Models;
using Microsoft.EntityFrameworkCore;

namespace DDACAssignment.Data
{
    public class DDACDbContext : DbContext
    {
        public DDACDbContext(DbContextOptions<DDACDbContext> options) : base(options) { }

        public DbSet<User> Users => Set<User>();
    }

}
