namespace Inventory_Managment.Domain.Entities
{
    /// <summary>
    /// Represents a product entity with business rule validation in setters.
    /// </summary>
    public class Product : BaseEntity
    {
        private string _name = default!;
        private decimal _price;
        private int _stockQuantity;
        private string? _description;

        public string Name
        {
            get => _name;
            set
            {
                var trimmed = value?.Trim() ?? string.Empty;
                if (trimmed.Length < 2)
                    throw new ArgumentException("Product name must have at least 2 characters.");
                _name = trimmed;
            }
        }

        public string? Description
        {
            get => _description;
            set
            {
                if (value is not null && value.Trim().Length < 5)
                    throw new ArgumentException("Product description must have at least 5 characters when provided.");
                _description = value?.Trim();
            }
        }

        public decimal Price
        {
            get => _price;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Product price must be greater than zero.");
                if (value > 999_999.99m)
                    throw new ArgumentException("Product price cannot exceed 999,999.99.");
                _price = value;
            }
        }

        public int StockQuantity
        {
            get => _stockQuantity;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Stock quantity cannot be negative.");
                if (value > 100_000)
                    throw new ArgumentException("Stock quantity cannot exceed 100,000 units.");
                _stockQuantity = value;
            }
        }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; } = default!;
        public Guid SupplierId { get; set; }
        public Supplier Supplier { get; set; } = default!;
        public ICollection<StockMovement> StockMovements { get; set; } = [];
    }
}
