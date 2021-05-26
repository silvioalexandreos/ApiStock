using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Stock.Infra.IoC.Modules;

namespace Stock.Infra.IoC
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddApplicationDependencies(this IServiceCollection services, IConfiguration configuration)
            => services
                .RegisterInfrastructureDepencedies(configuration)
                .RegisterBusinessDependencies(configuration);
    }
}
