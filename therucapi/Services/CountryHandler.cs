namespace therucapi;

public class CountryHandler : ICountryHandler
{
    private readonly IHttpHandler _httpHandler;

    public CountryHandler(IHttpHandler httpHandler)
    {
        _httpHandler = httpHandler;
    }
    public async Task<IEnumerable<CountryModel>?> GetCountriesAsync(CancellationToken cancellationToken = default)
    {
        string url = "https://restcountries.com/v2/all";
        var countries = await _httpHandler
                            .GetObjects<CountryModel>(url: url);
        return countries;
    }
}