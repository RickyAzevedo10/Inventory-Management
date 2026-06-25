namespace Inventory_Managment.Domain.Interfaces.Repository
{
    public interface IUnitOfWork
    {
        Task<bool> CommitAsync();

        IProductRepository ProductRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        ISupplierRepository SupplierRepository { get; }
    }
}
