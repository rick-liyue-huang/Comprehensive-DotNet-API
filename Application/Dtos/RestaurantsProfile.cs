using AutoMapper;
using Domain.Entities;

namespace Application.Dtos;

public class RestaurantsProfile : Profile
{
    public RestaurantsProfile()
    {
        CreateMap<Restaurant, RestaurantDto>()
            .ForMember(d
                => d.City, opt
                => opt.MapFrom(s => s.Address == null ? null : s.Address.City))

            .ForMember(d
                => d.PostalCode, opt
                => opt.MapFrom(s => s.Address == null ? null : s.Address.PostalCode))

            .ForMember(d
                => d.Street, opt
                => opt.MapFrom(s => s.Address == null ? null : s.Address.Street))

            .ForMember(d => d.Dishes, opt => opt.MapFrom(s => s.Dishes));
    }
}
