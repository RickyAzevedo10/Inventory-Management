using Inventory_Managment.Domain.Entities;
using Inventory_Managment.Domain.Interfaces.Repository;
using Inventory_Managment.Infrastructure.Data.Persistance;
using Microsoft.EntityFrameworkCore;

namespace Inventory_Managment.Infrastructure.Data.Repositories
{
    public class SupplierRepository : BaseRepository<Supplier>, ISupplierRepository
    {
        public SupplierRepository(DataContext context) : base(context)
        {
        }

        public override async Task<Supplier?> GetByIdAsync(Guid id)
        {
            return await GetEntity().FirstOrDefaultAsync(s => s.Id == id);
        }
    }
}
