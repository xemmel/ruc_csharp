using Microsoft.AspNetCore.Mvc;

namespace therucapi.Controllers;

[ApiController]
[Route("[controller]")]
public class CountryController : ControllerBase
{
    private readonly ILogger<CountryController> _logger;
    private readonly ICountryHandler _countryHandler;

    public CountryController(
            ILogger<CountryController> logger,
            ICountryHandler countryHandler)
    {
        _logger = logger;
        _countryHandler = countryHandler;
     
    }

    [HttpGet(Name = "GetCountries")]
    public async Task<IEnumerable<CountryModel>?> Get()
    {
        var countries = await _countryHandler
                        .GetCountriesAsync();
        var result = countries
                        .Where(c => c.Name.Contains("United"));
        return result;
    }
}
