using ApplicationLayer.Modules.WareHouseApplication;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ApplicationLayer.ApplicationLayerDependecyInjection
{
    public static class ApplicationLayerDependecyInjection
    {
        public static IServiceCollection AddApplicationLayerDependecyInjection(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddTransient<WareHouseApplication, WareHouseApplication>();
            return services;
        }
    }
}
