using Inventory_Managment.Domain.Entities;

namespace Inventory_Managment.Domain.Interfaces.Repository
{
    public interface ISupplierRepository : IBaseRepository<Supplier>
    {
        // GetByIdAsync is now inherited from IBaseRepository<Supplier>
    }
}
