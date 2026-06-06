using Inventory_Managment.Domain.Entities;

namespace Inventory_Managment.Domain.Interfaces
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        Task<Product?> GetByIdAsync(Guid id);
    }
}
