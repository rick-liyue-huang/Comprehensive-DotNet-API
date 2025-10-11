
using Domain.Entities;
using Domain.Repositories;
using Microsoft.Extensions.Logging;


namespace Application.Restaurants;

public class RestaurantsService(IRestaurantsRepository restaurantsRepository, ILogger<RestaurantsService> logger) : IRestaurantsService
{
    public async Task<IEnumerable<Restaurant>> GetAllRestaurants()
    {
        logger.LogInformation("Getting all restaurants");
        var restaurants = await restaurantsRepository.GetAllAsync();
        return restaurants;
    }

    public async Task<Restaurant?> GetRestaurantById(int id)
    {
        logger.LogInformation("Getting restaurant with id {Id}", id);
        var restaurant = await restaurantsRepository.GetByIdAsync(id);
        return restaurant;
    }
}
