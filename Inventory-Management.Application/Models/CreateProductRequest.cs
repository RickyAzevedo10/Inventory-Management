namespace Inventory_Managment.Application.Models
{
    /// <summary>
    /// Data transfer model for product creation requests.
    /// </summary>
    public class CreateProductRequest
    {
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public Guid CategoryId { get; set; }
        public Guid SupplierId { get; set; }
    }
}
