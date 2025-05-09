using Microsoft.Extensions.DependencyInjection;

namespace Pikot.DDD;

public static class ServiceRegistrations
{
    public static IServiceCollection AddDefaultClock(this IServiceCollection services)
    {
        return services.AddSingleton<IClock, Clock>();
    }
}