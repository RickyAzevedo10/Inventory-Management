using Inventory_Managment.Domain.Entities;

namespace Inventory_Managment.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<Product?> GetByIdAsync(Guid id);
    }
}
