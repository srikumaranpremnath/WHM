using DataLayer.Context;
using DataLayer.Interface;
using DataLayer.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace DataLayer.DependencyInjection
{

    public static class DataLayerDependencyInjection
    {
        public static IServiceCollection AddDataLayerDependencyInjection(this IServiceCollection services)
        {
            services.AddTransient<WHMDbContext, WHMDbContext>();
            services.AddTransient<IWareHouseRepository, WareHouseRepository>();

            return services;
        }
    }
}
