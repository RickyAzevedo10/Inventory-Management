using Inventory_Managment.Domain.Entities;
using Inventory_Managment.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inventory_Managment.Infrastructure.Data.Mappings
{
    internal class StockMovementMapping : IEntityTypeConfiguration<StockMovement>
    {
        public void Configure(EntityTypeBuilder<StockMovement> entity)
        {
            entity.ToTable("StockMovements");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Quantity).IsRequired();
            entity.Property(e => e.MovementType).IsRequired();
            entity.Property(e => e.ProductId).IsRequired();
            entity.Property(e => e.PerformedBy).HasMaxLength(100);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);

            entity.Property(e => e.MovementType)
                .HasConversion<int>();

            entity.HasQueryFilter(p => !p.IsDeleted);

            entity.HasOne(sm => sm.Product)
                .WithMany(p => p.StockMovements)
                .HasForeignKey(sm => sm.ProductId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
