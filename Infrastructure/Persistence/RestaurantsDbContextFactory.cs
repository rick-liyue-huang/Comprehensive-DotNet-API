using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure.Persistence
{
    public class RestaurantsDbContextFactory : IDesignTimeDbContextFactory<RestaurantsDbContext>
    {
        public RestaurantsDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<RestaurantsDbContext>();

            // ✅ 与 appsettings.json 一致的连接字符串
            optionsBuilder.UseSqlServer("Server=localhost,2022;Database=RestaurantDb;User Id=sa;Password=MyStrong#Pass123;TrustServerCertificate=True");

            return new RestaurantsDbContext(optionsBuilder.Options);
        }
    }
}
