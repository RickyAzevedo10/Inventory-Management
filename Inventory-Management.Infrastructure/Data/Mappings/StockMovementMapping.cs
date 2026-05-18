using Inventory_Managment.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inventory_Managment.Infrastructure.Data.Mappings
{
    internal class StockMovementMapping : IEntityTypeConfiguration<StockMovement>
    {
        public void Configure(EntityTypeBuilder<StockMovement> entity)
        {
            entity.HasKey(e => e.Id);
        }
    }
}
