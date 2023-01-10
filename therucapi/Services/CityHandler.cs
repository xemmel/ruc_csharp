namespace therucapi;

public class CityHandler : ICityHandler
{
    public async Task<IEnumerable<CityModel>?> GetCitiesAsync(string countryName)
    {
        switch(countryName.ToLower())
        {
            case "denmark": 
                return new List<CityModel> {
                    new CityModel {CityId = 1, Name = "Copenhagen"},
                    new CityModel {CityId = 2, Name = "Aarhus"},
                    new CityModel {CityId = 3, Name = "Roskilde"},

                };
            default:
                return new List<CityModel> {
                    new CityModel {CityId = 11, Name = "C1"},
                    new CityModel {CityId = 21, Name = "C2"},
                    new CityModel {CityId = 31, Name = "C3"},
         
                };
        }
    }

    public async Task<IEnumerable<CityModel>?> GetCitiesAsync()
    {
         return new List<CityModel> {
                    new CityModel {CityId = 1, Name = "Copenhagen"},
                    new CityModel {CityId = 2, Name = "Aarhus"},
                    new CityModel {CityId = 3, Name = "Roskilde"},
                    new CityModel {CityId = 11, Name = "C1"},
                    new CityModel {CityId = 21, Name = "C2"},
                    new CityModel {CityId = 31, Name = "C3"},
         
                };
    }
}