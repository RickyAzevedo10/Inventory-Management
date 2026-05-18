namespace Inventory_Managment.Domain.Entities
{
    /// <summary>
    /// Base entity containing common auditing and identification fields.
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Unique identifier of the entity.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Username or identifier of the user who created the entity.
        /// </summary>
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Timestamp when the entity was created.
        /// </summary>
        public DateTime CreatedWhen { get; set; }

        /// <summary>
        /// Username or identifier of the user who last modified the entity.
        /// </summary>
        public string? ChangedBy { get; set; }

        /// <summary>
        /// Timestamp when the entity was last modified.
        /// </summary>
        public DateTime? ChangedWhen { get; set; }

        /// <summary>
        /// Indicates whether the entity is soft-deleted.
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
