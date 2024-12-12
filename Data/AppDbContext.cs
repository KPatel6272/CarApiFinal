using CarApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CarApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; } = null!;

        // Override OnModelCreating to seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed the Cars table with some initial data
            modelBuilder.Entity<Car>().HasData(
                new Car { Id = 1, Make = "Toyota", Model = "Camry", Year = 2020 },
                new Car { Id = 2, Make = "Honda", Model = "Civic", Year = 2021 },
                new Car { Id = 3, Make = "Ford", Model = "Focus", Year = 2019 },
                new Car { Id = 4, Make = "Chevrolet", Model = "Malibu", Year = 2022 }
            );
        }
    }
}
