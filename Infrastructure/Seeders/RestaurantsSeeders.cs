

using Domain.Entities;
using Infrastructure.Persistence;

namespace Infrastructure.Seeders;

public class RestaurantsSeeders(RestaurantsDbContext dbContext) : IRestaurantsSeeders
{
    public async Task Seed()
    {
        if (await dbContext.Database.CanConnectAsync())
        {
            if (!dbContext.Restaurants.Any())
            {
                var restaurants = GetRestaurants();
                await dbContext.Restaurants.AddRangeAsync(restaurants);
                await dbContext.SaveChangesAsync();
            }
        }
    }

    private ICollection<Restaurant> GetRestaurants()
    {
        List<Restaurant> restaurants =
        [
            new()
            {
                Name = "KFC",
                Description = "Fast food restaurant",
                Category = "Fast food",
                HasDelivery = true,
                ContactEmail = "contact@kfc.com",
                Dishes =
                [
                    new()
                    {
                        Name = "Chicken",
                        Description = "Chicken",
                        Price = 10
                    },new Dish()
                    {
                        Name = "French Fries",
                        Description = "French Fries",
                        Price = 5
                    },new Dish()
                    {
                        Name = "Coca Cola",
                        Description = "Coca Cola",
                        Price = 2
                    }
                ],
                Address = new()
                {
                    City = "New York",
                    Street = "Street one",
                    PostalCode = "12345"
                }
            },
            new Restaurant()
            {
                Name = "Burger King",
                Description = "Fast food restaurant",
                Category = "Fast food",
                HasDelivery = true,
                ContactEmail = "contact@burgerking.com",
                Dishes =
                [
                    new()
                    {
                        Name = "Burger",
                        Description = "Burger",
                        Price = 10
                    },new Dish()
                ],
                Address = new()
                {
                    City = "London",
                    Street = "Street two",
                    PostalCode = "67890"
                }
            }
        ];

        return restaurants;
    }

}
