namespace Inventory_Managment.Domain.Entities
{
    /// <summary>
    /// Represents a category used to group products.
    /// </summary>
    public class Category : BaseEntity
    {
        /// <summary>
        /// Name of the category.
        /// </summary>
        public string Name { get; set; } = default!;

        /// <summary>
        /// Optional description of the category.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Collection of products associated with this category.
        /// </summary>
        public ICollection<Product> Products { get; set; } = [];
    }
}
