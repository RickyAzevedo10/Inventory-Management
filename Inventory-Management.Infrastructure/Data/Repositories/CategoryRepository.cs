using Inventory_Managment.Domain.Entities;
using Inventory_Managment.Domain.Interfaces.Repository;
using Inventory_Managment.Infrastructure.Data.Persistance;
using Microsoft.EntityFrameworkCore;

namespace Inventory_Managment.Infrastructure.Data.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(DataContext context) : base(context)
        {
        }

        public override async Task<Category?> GetByIdAsync(Guid id)
        {
            return await GetEntity().FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
