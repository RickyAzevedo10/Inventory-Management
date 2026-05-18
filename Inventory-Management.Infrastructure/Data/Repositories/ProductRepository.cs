using Inventory_Managment.Domain.Entities;
using Inventory_Managment.Domain.Interfaces;
using Inventory_Managment.Infrastructure.Data.Persistance;
using Microsoft.EntityFrameworkCore;

namespace Inventory_Managment.Infrastructure.Data.Repositories
{
    internal class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context)
        {
        }

        public async Task<Product?> GetByIdAsync(Guid id)
        {
            return await GetEntity().FirstOrDefaultAsync(u => u.Id == id);
        }
    }
}
