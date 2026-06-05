using Inventory_Managment.Application.Interfaces;
using Inventory_Managment.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Inventory_Management.Application
{
    public static class Program
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductHandler>();

            return services;
        }
    }
}