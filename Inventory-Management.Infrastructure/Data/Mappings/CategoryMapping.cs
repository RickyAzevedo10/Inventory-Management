using Inventory_Managment.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inventory_Managment.Infrastructure.Data.Mappings
{
    internal class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> entity)
        {
            entity.ToTable("Categories");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);

            entity.HasIndex(e => e.Name).IsUnique();

            entity.HasQueryFilter(p => !p.IsDeleted);

            entity.HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasData(
                new Category { Id = Guid.Parse("11111111-1111-1111-1111-111111111111"), Name = "Electronics", Description = "Electronic devices and accessories", CreatedWhen = DateTime.UtcNow },
                new Category { Id = Guid.Parse("22222222-2222-2222-2222-222222222222"), Name = "Clothing", Description = "Apparel and fashion items", CreatedWhen = DateTime.UtcNow },
                new Category { Id = Guid.Parse("33333333-3333-3333-3333-333333333333"), Name = "Food", Description = "Food and beverage products", CreatedWhen = DateTime.UtcNow },
                new Category { Id = Guid.Parse("44444444-4444-4444-4444-444444444444"), Name = "Home", Description = "Home and furniture items", CreatedWhen = DateTime.UtcNow },
                new Category { Id = Guid.Parse("55555555-5555-5555-5555-555555555555"), Name = "Sports", Description = "Sports and fitness equipment", CreatedWhen = DateTime.UtcNow }
            );
        }
    }
}
