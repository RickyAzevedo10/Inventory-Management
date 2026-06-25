using Inventory_Managment.Domain.Entities;
using Inventory_Managment.Domain.Interfaces.Provider;
using Inventory_Managment.Domain.Interfaces.Repository;

namespace Inventory_Managment.Infrastructure.Providers
{
    /// <summary>
    /// Handles supplier data retrieval using the unit of work pattern.
    /// </summary>
    public class SupplierProvider : ISupplierProvider
    {
        private readonly IUnitOfWork _unitOfWork;

        public SupplierProvider(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Retrieves a supplier by its unique identifier.
        /// </summary>
        public async Task<Supplier?> GetByIdAsync(Guid id)
        {
            return await _unitOfWork.SupplierRepository.GetByIdAsync(id);
        }
    }
}
