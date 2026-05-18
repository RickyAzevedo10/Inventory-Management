using Inventory_Managment.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inventory_Managment.Infrastructure.Data.Mappings
{
    internal class SupplierMapping : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> entity)
        {
            entity.ToTable("Suppliers");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Name).IsRequired().HasMaxLength(200);
            entity.Property(e => e.ContactEmail).HasMaxLength(100);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);

            entity.HasIndex(e => e.Name).IsUnique();

            entity.HasQueryFilter(p => !p.IsDeleted);

            entity.HasMany(s => s.Products)
                .WithOne(p => p.Supplier)
                .HasForeignKey(p => p.SupplierId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasData(
                new Supplier { Id = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), Name = "TechSupply Co", ContactEmail = "contact@techsupply.com", Phone = "+351 123 456 789", Address = "Lisbon, Portugal", CreatedWhen = DateTime.UtcNow },
                new Supplier { Id = Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), Name = "Global Goods", ContactEmail = "sales@globalgoods.com", Phone = "+351 234 567 890", Address = "Porto, Portugal", CreatedWhen = DateTime.UtcNow },
                new Supplier { Id = Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccccc"), Name = "Premium Imports", ContactEmail = "info@premiumimports.com", Phone = "+351 345 678 901", Address = "Braga, Portugal", CreatedWhen = DateTime.UtcNow }
            );
        }
    }
}
