using Inventory_Managment.Domain.Entities;
using Inventory_Managment.Domain.Interfaces.Provider;
using Inventory_Managment.Domain.Interfaces.Repository;

namespace Inventory_Managment.Infrastructure.Providers
{
    /// <summary>
    /// Handles category data retrieval using the unit of work pattern.
    /// </summary>
    public class CategoryProvider : ICategoryProvider
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryProvider(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Retrieves a category by its unique identifier.
        /// </summary>
        public async Task<Category?> GetByIdAsync(Guid id)
        {
            return await _unitOfWork.CategoryRepository.GetByIdAsync(id);
        }
    }
}
