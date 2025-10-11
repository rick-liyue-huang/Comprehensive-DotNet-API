using Application.Dtos;
// using Domain.Entities;

namespace Application.Restaurants;

public interface IRestaurantsService
{
    Task<IEnumerable<RestaurantDto>> GetAllRestaurants();
    Task<RestaurantDto?> GetRestaurantById(int id);
}