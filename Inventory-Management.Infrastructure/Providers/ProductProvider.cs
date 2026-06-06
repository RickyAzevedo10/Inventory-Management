using Inventory_Managment.Domain.Entities;
using Inventory_Managment.Domain.Interfaces;

namespace Inventory_Managment.Infrastructure.Providers
{
    /// <summary>
    /// Handles product persistence using the unit of work pattern.
    /// </summary>
    public class ProductProvider : IProductProvider
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductProvider(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Persists a product entity to the database.
        /// </summary>
        public async Task<Product> CreateProductAsync(Product product)
        {
            await _unitOfWork.ProductRepository.AddAsync(product);
            await _unitOfWork.CommitAsync();
            return product;
        }
    }
}
