using System.ComponentModel.DataAnnotations;

namespace HotelListingAPI.Dtos.Countries
{
    public class CreateCountryDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string ShortName { get; set; }
    }
}
