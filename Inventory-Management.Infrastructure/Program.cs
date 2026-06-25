using Inventory_Managment.Domain.Interfaces.Provider;
using Inventory_Managment.Domain.Interfaces.Repository;
using Inventory_Managment.Infrastructure.Data;
using Inventory_Managment.Infrastructure.Data.Persistance;
using Inventory_Managment.Infrastructure.Data.Repositories;
using Inventory_Managment.Infrastructure.Providers;
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
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ISupplierRepository, SupplierRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IProductProvider, ProductProvider>();
            services.AddScoped<ICategoryProvider, CategoryProvider>();
            services.AddScoped<ISupplierProvider, SupplierProvider>();

            return services;
        }
    }
}
