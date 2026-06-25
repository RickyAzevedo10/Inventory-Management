using Inventory_Managment.Domain.Entities;

namespace Inventory_Managment.Domain.Interfaces.Provider
{
    /// <summary>
    /// Defines the contract for supplier data retrieval operations.
    /// </summary>
    public interface ISupplierProvider
    {
        Task<Supplier?> GetByIdAsync(Guid id);
    }
}
