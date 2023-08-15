using HotelListingAPI.Data;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace HotelListingAPI.Repositories
{
    public class HotelRepository : GenericRepository<Hotel>, IHotelRepository
    {

        public HotelRepository(HotelListingDbContext dbContext) : base(dbContext)
        {

        }
    }
}
