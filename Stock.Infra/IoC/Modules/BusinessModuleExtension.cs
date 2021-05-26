using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Stock.Business.Interfaces.Services;
using Stock.Services.Business;

namespace Stock.Infra.IoC.Modules
{
    internal static class BusinessModuleExtension
    {
        internal static IServiceCollection RegisterBusinessDependencies(this IServiceCollection services, IConfiguration configuration) 
            => services.AddScoped<IStockService, StockService>();
    }
}
