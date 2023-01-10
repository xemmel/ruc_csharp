namespace thethirdrucconsole;
using Microsoft.Extensions.DependencyInjection;

public static class DIFactory
{
    public static IServiceCollection AddAllServices(this IServiceCollection services)
    {
        services
            .AddScoped<IEmailHandler,HotmailEmailHandler>()
            .AddScoped<IProcessHandler,MyProcessHandler>()
            .AddScoped<IRUCLogger,AltConsoleRucLogger>()


            .AddSingleton<Application>()
            ;
        return services;
    }

    public static T GetService<T>() where T : class
    {
        var services = new ServiceCollection();
        services.AddAllServices();
        return services.BuildServiceProvider().GetRequiredService<T>();
    }
}