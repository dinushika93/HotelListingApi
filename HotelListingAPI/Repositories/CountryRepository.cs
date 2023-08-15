using HotelListingAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListingAPI.Repositories
{
    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
        private readonly HotelListingDbContext _dbContext;
        public CountryRepository(HotelListingDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Country> GetDetails(int id)
        {
            return await _dbContext.Countries.Include(x => x.Hotels).FirstOrDefaultAsync(x=> x.Id == id);
        }
    }
}
