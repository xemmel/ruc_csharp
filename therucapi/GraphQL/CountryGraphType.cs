namespace therucapi;

public class CountryGraphType : ObjectType<CountryModel>
{
    protected override void Configure(IObjectTypeDescriptor<CountryModel> descriptor)
    {
        descriptor
           .Field("cities")
           .ResolveWith<Resolvers>(r => r.GetCitiesByCountryAsync(default!,default!,default!));
    }

    private class Resolvers
    {
        public Task<IEnumerable<CityModel>?> GetCitiesByCountryAsync(
            [Service] ICityHandler cityHandler,
            [Parent] CountryModel countryModel,
            CancellationToken cancellationToken
        ) => cityHandler.GetCitiesAsync(countryName: countryModel.Name);
    }
}