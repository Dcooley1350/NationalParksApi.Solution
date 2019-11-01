using Microsoft.EntityFrameworkCore;

namespace NationalParksApi.Models
{
    public class NationalParksApiContext : DbContext
    {
        public NationalParksApiContext(DbContextOptions<NationalParksApiContext> options) : base(options)
        {

        }
        public DbSet<Park> Parks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Park>()
                .HasData(
                    new Park { }
                )
        }
    }
}