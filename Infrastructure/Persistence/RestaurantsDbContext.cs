
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

public class RestaurantsDbContext(DbContextOptions<RestaurantsDbContext> options): DbContext(options)
{
    internal DbSet<Restaurant> Restaurants { get; set; }
    internal DbSet<Dish> Dishes { get; set; }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.UseSqlServer("Server=localhost,2022;Database=RestaurantDb;User Id=sa;Password=MyStrong#Pass123;TrustServerCertificate=True");
    // }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
      modelBuilder.Entity<Restaurant>()
        .OwnsOne(r => r.Address); // Restaurant has an Address property, so don't need to create a separate table for it.
      
      modelBuilder.Entity<Restaurant>()
        .HasMany(r => r.Dishes)
        .WithOne()
        .HasForeignKey(d => d.RestaurantId); // Dash has a separated table, so we need to specify the foreign key.
    }
}
