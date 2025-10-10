
using Infrastructure.Persistence;
using Infrastructure.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("RestaurantDBString");
        services.AddDbContext<RestaurantsDbContext>(options => options.UseSqlServer(connectionString));

        // add seeders
        services.AddScoped<IRestaurantsSeeders, RestaurantsSeeders>();
    }
}
