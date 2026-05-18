namespace Inventory_Managment.Domain.DTO
{
    public class ProductModelResponse
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
    }
}
