using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;

namespace DataAccessLayer.Implementation
{
    public class CountryRepository : ICountryRepository
    {
        public readonly WeatherContext weatherContext;

        public CountryRepository(WeatherContext weatherContext)
        {
            this.weatherContext = weatherContext;
        }

        public async Task AddCountryAsync(Country country)
        {
            await weatherContext.Countries.AddAsync(country);
            await weatherContext.SaveChangesAsync();
        }
    }
}
