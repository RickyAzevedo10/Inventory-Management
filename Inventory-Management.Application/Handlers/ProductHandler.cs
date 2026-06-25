using FluentValidation;
using Inventory_Managment.Application.Interfaces;
using Inventory_Managment.Application.Models;
using Inventory_Managment.Domain.Entities;
using Inventory_Managment.Domain.Interfaces.Provider;

namespace Inventory_Managment.Application.Handlers
{
    /// <summary>
    /// Handles product creation by validating input and persisting the entity.
    /// </summary>
    public class ProductHandler : IProductHandler
    {
        private readonly IProductProvider _productProvider;
        private readonly ICategoryProvider _categoryProvider;
        private readonly ISupplierProvider _supplierProvider;
        private readonly IValidator<CreateProductRequest> _validator;

        public ProductHandler(IProductProvider productProvider, ICategoryProvider categoryProvider, ISupplierProvider supplierProvider, IValidator<CreateProductRequest> validator)
        {
            _productProvider = productProvider;
            _categoryProvider = categoryProvider;
            _supplierProvider = supplierProvider;
            _validator = validator;
        }

        /// <summary>
        /// Validates the request, maps it to a Product entity, and persists it.
        /// </summary>
        public async Task<Product> CreateProductAsync(CreateProductRequest request)
        {
            await _validator.ValidateAndThrowAsync(request);

            Category? category = await _categoryProvider.GetByIdAsync(request.CategoryId) ?? throw new ValidationException("Category with the provided ID does not exist.");

            Supplier? supplier = await _supplierProvider.GetByIdAsync(request.SupplierId) ?? throw new ValidationException("Supplier with the provided ID does not exist.");

            var product = new Product
            {
                Name = request.Name,
                Description = request.Description,
                Price = request.Price,
                StockQuantity = request.StockQuantity,
                CategoryId = request.CategoryId,
                SupplierId = request.SupplierId
            };

            return await _productProvider.CreateProductAsync(product);
        }
    }
}
