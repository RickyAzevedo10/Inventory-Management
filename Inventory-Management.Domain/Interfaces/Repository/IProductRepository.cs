using Inventory_Managment.Domain.Entities;

namespace Inventory_Managment.Domain.Interfaces.Repository
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        // GetByIdAsync is now inherited from IBaseRepository<Product>
    }
}
