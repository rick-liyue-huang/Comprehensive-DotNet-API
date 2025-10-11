using Domain.Entities;

namespace Application.Restaurants;

public interface IRestaurantsService
{
    Task<IEnumerable<Restaurant>> GetAllRestaurants();
    Task<Restaurant?> GetRestaurantById(int id);
}