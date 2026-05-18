namespace Inventory_Managment.Domain.Entities
{
    /// <summary>
    /// Represents a product stored in the inventory.
    /// </summary>
    public class Product : BaseEntity
    {
        /// <summary>
        /// Name of the product.
        /// </summary>
        public string Name { get; set; } = default!;

        /// <summary>
        /// Optional description of the product.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Price of the product.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Current stock quantity available.
        /// </summary>
        public int StockQuantity { get; set; }

        /// <summary>
        /// Identifier of the category the product belongs to.
        /// </summary>
        public Guid CategoryId { get; set; }

        /// <summary>
        /// Navigation property for the product's category.
        /// </summary>
        public Category Category { get; set; } = default!;

        /// <summary>
        /// Identifier of the supplier providing the product.
        /// </summary>
        public Guid SupplierId { get; set; }

        /// <summary>
        /// Navigation property for the product's supplier.
        /// </summary>
        public Supplier Supplier { get; set; } = default!;

        /// <summary>
        /// Collection of stock movements related to this product.
        /// </summary>
        public ICollection<StockMovement> StockMovements { get; set; } = [];
    }
}
