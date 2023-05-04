using Microsoft.AspNetCore.Mvc;
using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.DTOs;

namespace WebApi.Controllers    
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpPost]
        public async Task<IActionResult> AddCountry([FromBody] CountryDto countryDto)
        {
            if (countryDto == null) 
            { 
                return BadRequest();
            }

            if(string.Equals(countryDto.Name, "string"))
            {
                return BadRequest();
            }

            try
            {
                await _countryService.AddCountryAsync(countryDto);
                return Ok();
            }
            catch (Exception ex) 
            { 
                return BadRequest(ex);
            }
        }
    }
}
