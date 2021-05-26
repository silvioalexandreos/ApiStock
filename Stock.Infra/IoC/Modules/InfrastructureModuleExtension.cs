using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Stock.Business.Interfaces.Repositories;
using Stock.Infra.Data.Context;
using Stock.Infra.Data.Repositories;

namespace Stock.Infra.IoC.Modules
{
    internal static class InfrastructureModuleExtension
    {
        private const string StockConnectionName = "StockConnection";

        internal static IServiceCollection RegisterInfrastructureDepencedies(this IServiceCollection services, IConfiguration configuration)
            => services
                .RegisterContext(configuration)
                .RegisterRepositories();

        private static IServiceCollection RegisterRepositories(this IServiceCollection services)
            => services
                .AddScoped<ICategoryRepository, CategoryRepository>()
                .AddScoped<IProductRepository, ProductRepository>();

        private static IServiceCollection RegisterContext(this IServiceCollection services, IConfiguration configuration)
            => services.AddDbContext<StockContext>(options
                => options.UseNpgsql(configuration.GetConnectionString(StockConnectionName)));
    }
}
