namespace Inventory_Managment.Domain.Entities
{
    /// <summary>
    /// Represents a supplier that provides products.
    /// </summary>
    public class Supplier : BaseEntity
    {
        /// <summary>
        /// Name of the supplier.
        /// </summary>
        public string Name { get; set; } = default!;

        /// <summary>
        /// Email contact of the supplier.
        /// </summary>
        public string? ContactEmail { get; set; }

        /// <summary>
        /// Phone number of the supplier.
        /// </summary>
        public string? Phone { get; set; }

        /// <summary>
        /// Physical address of the supplier.
        /// </summary>
        public string? Address { get; set; }

        /// <summary>
        /// Collection of products provided by this supplier.
        /// </summary>
        public ICollection<Product> Products { get; set; } = [];
    }
}
