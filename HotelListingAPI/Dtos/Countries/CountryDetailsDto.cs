using HotelListingAPI.Data;
using HotelListingAPI.Dtos.Hotels;

namespace HotelListingAPI.Dtos.Countries
{
    public class CountryDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public IList<HotelDto> Hotels { get; set; }
    }
}
