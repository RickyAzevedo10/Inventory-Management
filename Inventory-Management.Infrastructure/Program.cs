using Inventory_Managment.Domain.Interfaces;
using Inventory_Managment.Infrastructure.Data;
using Inventory_Managment.Infrastructure.Data.Persistance;
using Inventory_Managment.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Inventory_Management.Infrastructure
{
    public static class Program
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}