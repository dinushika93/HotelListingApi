using HotelListingAPI.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListingAPI.Dtos.Hotels
{
    public class HotelDto : HotelBaseDto
    {
       public int Id { get; set; }
    }
}