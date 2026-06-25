using Inventory_Managment.Application.Models;
using Inventory_Managment.Domain.Entities;

namespace Inventory_Managment.Application.Interfaces
{
    /// <summary>
    /// Defines the contract for product service operations.
    /// </summary>
    public interface IProductHandler
    {
        Task<Product> CreateProductAsync(CreateProductRequest request);
    }
}
