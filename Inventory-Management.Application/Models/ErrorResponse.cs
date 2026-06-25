namespace Inventory_Managment.Application.Models
{
    /// <summary>
    /// Standardized error response structure.
    /// </summary>
    public class ErrorResponse
    {
        public bool Success { get; set; } = false;
        public string? Message { get; set; }
        public IEnumerable<string>? Errors { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}
