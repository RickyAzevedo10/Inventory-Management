using Inventory_Managment.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inventory_Managment.Infrastructure.Data.Mappings
{
    internal class SupplierMapping : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> entity)
        {
            entity.HasKey(e => e.Id);
            entity.HasIndex(u => u.Name).IsUnique();
        }

        //public void SeedData(EntityTypeBuilder<Product> entity)
        //{
        //    // Verificar se já existem dados
        //    if (!entity.Metadata.GetSeedData().Any())
        //    {
        //        entity.HasData(
        //            new ExpenseCategory { Id = 1, Name = "Salários", Description = "Despesas relacionadas com o pagamento de salários a jogadores, treinadores e funcionários." } }
        //        );
        //    }
        //}
    }
}
