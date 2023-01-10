namespace therucapi;

public interface ICountryHandler
{
    Task<IEnumerable<CountryModel>?> GetCountriesAsync(CancellationToken cancellationToken = default);
}