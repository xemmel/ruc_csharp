namespace therucapi;

public interface ICityHandler
{
    Task<IEnumerable<CityModel>?> GetCitiesAsync(string countryName);
    Task<IEnumerable<CityModel>?> GetCitiesAsync();

}