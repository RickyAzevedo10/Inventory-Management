using FluentValidation;
using Inventory_Managment.Application.Handlers;
using Inventory_Managment.Application.Interfaces;
using Inventory_Managment.Application.Validators;
using Microsoft.Extensions.DependencyInjection;

namespace Inventory_Management.Application
{
    public static class Program
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IProductHandler, ProductHandler>();
            services.AddValidatorsFromAssemblyContaining<CreateProductValidator>();

            return services;
        }
    }
}