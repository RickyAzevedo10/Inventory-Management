using Inventory_Managment.Domain.Entities;

namespace Inventory_Managment.Domain.Interfaces.Provider
{
    /// <summary>
    /// Defines the contract for product data persistence operations.
    /// </summary>
    public interface IProductProvider
    {
        Task<Product> CreateProductAsync(Product product);
    }
}
