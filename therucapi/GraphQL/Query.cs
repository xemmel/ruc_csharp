namespace therucapi;

public class Query
{
    public string GetVersion() => "1.4.0";

    [UseFiltering]
    [UseSorting]
    public Task<IEnumerable<CountryModel>?> GetCountriesAsync(
        [Service] ICountryHandler countryHandler,
        CancellationToken cancellationToken
    ) => countryHandler.GetCountriesAsync(cancellationToken);

    [UseFiltering]
    [UseSorting]
    public Task<IEnumerable<CityModel>?> GetCitiesAsync(
    [Service] ICityHandler cityHandler,
    CancellationToken cancellationToken
) => cityHandler.GetCitiesAsync();
}