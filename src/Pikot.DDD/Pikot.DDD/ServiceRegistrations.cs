using Microsoft.Extensions.DependencyInjection;
using Pikot.DDD.Ports;

namespace Pikot.DDD;

public static class ServiceRegistrations
{
    public static IServiceCollection AddDefaultClock(this IServiceCollection services)
    {
        return services.AddSingleton<IClock, Clock>();
    }
}