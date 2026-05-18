namespace Inventory_Managment.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> CommitAsync();

        IProductRepository ProductRepository { get; }
    }
}
