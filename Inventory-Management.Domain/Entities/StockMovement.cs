using Inventory_Managment.Domain.Enums;

namespace Inventory_Managment.Domain.Entities
{
    /// <summary>
    /// Represents a stock movement (in, out, or adjustment) for a product.
    /// </summary>
    public class StockMovement : BaseEntity
    {
        /// <summary>
        /// Identifier of the product affected by the movement.
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// Navigation property for the related product.
        /// </summary>
        public Product Product { get; set; } = default!;

        /// <summary>
        /// Quantity moved (positive = in, negative = out).
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Type of stock movement.
        /// </summary>
        public StockMovementType MovementType { get; set; }

        /// <summary>
        /// Optional user who performed the movement.
        /// </summary>
        public string? PerformedBy { get; set; }
    }
}
