using Inventory_Managment.Domain.Entities;

namespace Inventory_Managment.Domain.Interfaces.Repository
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
        // GetByIdAsync is now inherited from IBaseRepository<Category>
    }
}
