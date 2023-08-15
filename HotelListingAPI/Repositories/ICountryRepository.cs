using HotelListingAPI.Data;

namespace HotelListingAPI.Repositories
{
    public interface ICountryRepository : IGenericRepository<Country>
    {
        Task<Country> GetDetails(int id);
    }
}
