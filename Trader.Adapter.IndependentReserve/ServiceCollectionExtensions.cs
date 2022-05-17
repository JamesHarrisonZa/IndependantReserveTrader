using Microsoft.Extensions.DependencyInjection;
using Trader.Domain.OutboundPorts;

namespace Trader.Adapter.IndependentReserve;

public static class ServiceCollectionExtensions
{
    public static void AddIndependentReserveAdapter(this IServiceCollection services)
    {
        services.AddScoped<IBalancesRepository, BalancesRepository>();
    }
}