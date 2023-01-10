namespace therucapi;

public static class DIFactory
{
    public static IServiceCollection AddTheRucAPI(this IServiceCollection services)
    {
        services 
            .AddScoped<IGreetingHandler, DummyGreetingHandler>()
            .AddScoped<IMessageHandler, DummyMessageHandler>()
            .AddScoped<IHttpHandler, HttpHandler>()
            .AddScoped<ICountryHandler, CountryHandler>()
            .AddScoped<ICityHandler, CityHandler>()




            ;

        return services;
    }
}