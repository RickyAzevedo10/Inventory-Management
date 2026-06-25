using Inventory_Managment.Domain.Entities;

namespace Inventory_Managment.Domain.Interfaces.Provider
{
    /// <summary>
    /// Defines the contract for category data retrieval operations.
    /// </summary>
    public interface ICategoryProvider
    {
        Task<Category?> GetByIdAsync(Guid id);
    }
}
