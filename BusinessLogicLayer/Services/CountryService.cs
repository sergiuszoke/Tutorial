using BusinessLogicLayer.DTOs;
using BusinessLogicLayer.Interfaces;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;

namespace BusinessLogicLayer.Services
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;

        public CountryService(ICountryRepository countryRepository)
        {
            this._countryRepository = countryRepository;
        }

        public async Task AddCountryAsync(CountryDto countryDto)
        {
            var country = new Country()
            {
                Id = countryDto.Id,
                Name = countryDto.Name
            };

            await _countryRepository.AddCountryAsync(country);
        }
    }
}
