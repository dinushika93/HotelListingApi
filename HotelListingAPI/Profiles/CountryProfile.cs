using AutoMapper;
using HotelListingAPI.Data;
using HotelListingAPI.Dtos;
using HotelListingAPI.Dtos.Countries;
using HotelListingAPI.Dtos.Hotels;
using Microsoft.AspNetCore.Authentication;

namespace HotelListingAPI.Profiles
{
    public class CountryProfile : Profile
    {
        public CountryProfile()
        {
            CreateMap<Country, CountryDto>().ReverseMap();    
            CreateMap<Country, CountryDetailsDto>().ReverseMap();
            CreateMap<CreateCountryDto, Country>().ReverseMap(); 
            CreateMap<UpdateCountryDto, Country>().ReverseMap();

            CreateMap<Hotel, HotelDto>().ReverseMap();
            CreateMap<Hotel, HotelCreateDto>().ReverseMap();
        }
    }
}
