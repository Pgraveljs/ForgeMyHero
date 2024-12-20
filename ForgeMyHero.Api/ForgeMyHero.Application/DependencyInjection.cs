using Microsoft.Extensions.DependencyInjection;

namespace ForgeMyHero.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        //service.AddMediatR(cfg => {
        //    cfg.RedisterServicesFromAssembly(AssemblyLoadEventArgs.GetExecutingAssembly());
        //}})
        return services;
    }
}
