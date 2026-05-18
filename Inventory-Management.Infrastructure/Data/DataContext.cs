using Inventory_Managment.Domain.Entities;
using Inventory_Managment.Infrastructure.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Inventory_Managment.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        //Entities
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<StockMovement> StockMovement { get; set; }
        public DbSet<Supplier> Supplier { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Mappings
            builder.ApplyConfiguration(new ProductMapping());
            builder.ApplyConfiguration(new CategoryMapping());
            builder.ApplyConfiguration(new StockMovementMapping());
            builder.ApplyConfiguration(new SupplierMapping());
        }
    }
}
