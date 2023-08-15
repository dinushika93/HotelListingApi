using System.ComponentModel.DataAnnotations;

namespace HotelListingAPI.Dtos.Countries
{
    public class UpdateCountryDto
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}
