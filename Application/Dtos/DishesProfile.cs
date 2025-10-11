
using AutoMapper;
using Domain.Entities;

namespace Application.Dtos;

public class DishesProfile : Profile
{
    public DishesProfile()
    {
        CreateMap<Dish, DishDto>();
    }
}
