using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace NationalParksApi.Models
{
    public class NationalParksApiContext : IdentityDbContext<ApplicationUser>
    {
        public NationalParksApiContext(DbContextOptions<NationalParksApiContext> options) : base(options)
        { }
        public DbSet<Park> Parks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Park>()
                .HasData(
                    new Park { ParkId = 1, Name = "Yellow Stone", Description = "A beautiful little park.", Location = "Wyoming"},
                    new Park { ParkId = 2, Name = "Crater Lake", Description = "Big 'Ol Deep Clear Lake", Location = "Oregon"},
                    new Park { ParkId = 3, Name = "Big Bear", Description = "Big 'Ol Mountain" , Location = "California"},
                    new Park { ParkId = 4, Name = "Grand Canyon", Description = "Big 'Ol crack in the ground", Location = "Nevada"},
                    new Park { ParkId = 5, Name = "Jedidiah Smith RedWoods", Description = "Big Ol Trees" , Location = "California"},
                    new Park { ParkId = 6, Name = "EverGlades", Description = "Dirty Ol Water", Location ="Florida"}
                );
            // builder.Entity<ApplicationUser>().HasData(
            //     new { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
            //     new { Id = "2", Name = "Customer", NormalizedName = "ADMIN" }
            //     );
        }
    }
}