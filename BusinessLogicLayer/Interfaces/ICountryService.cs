using BusinessLogicLayer.DTOs;

namespace BusinessLogicLayer.Interfaces
{
    public interface ICountryService
    {
        Task AddCountryAsync(CountryDto countryDto);
    }
}
