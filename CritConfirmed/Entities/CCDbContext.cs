using Microsoft.EntityFrameworkCore;

namespace CritConfirmed.Entities
{
    public class CCDbContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }

        public CCDbContext(DbContextOptions<CCDbContext> options)
        : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
