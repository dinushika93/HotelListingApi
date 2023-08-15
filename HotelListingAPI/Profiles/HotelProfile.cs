using AutoMapper;
using HotelListingAPI.Data;
using HotelListingAPI.Dtos.Hotels;

namespace HotelListingAPI.Profiles
{
    public class HotelProfile : Profile 
    {
        public HotelProfile()
        {
            CreateMap< Hotel, HotelDto>().ReverseMap();
        }
    }
}
