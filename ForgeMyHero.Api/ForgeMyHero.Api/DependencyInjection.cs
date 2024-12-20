namespace ForgeMyHero.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddApiServices(this IServiceCollection services)
    {
        //service.AddCarter();

        return services;
    }

    public static WebApplication WebApiServices(this WebApplication app)
    {
        //app.MApCarter();
        return app;
    }
}
