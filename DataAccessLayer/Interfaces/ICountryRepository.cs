using DataAccessLayer.Models;

namespace DataAccessLayer.Interfaces
{
    public interface ICountryRepository
    {
        Task AddCountryAsync(Country country);
    }
}
