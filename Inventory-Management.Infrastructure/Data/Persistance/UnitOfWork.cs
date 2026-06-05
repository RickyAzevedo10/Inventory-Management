using Inventory_Managment.Domain.Interfaces;
using Inventory_Managment.Infrastructure.Data.Repositories;

namespace Inventory_Managment.Infrastructure.Data.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;
        private readonly IProductRepository _productRepository;

        public UnitOfWork(DataContext context, IProductRepository productRepository)
        {
            _context = context;
            _productRepository = productRepository;
        }

        public async Task<bool> CommitAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public IProductRepository ProductRepository => _productRepository;
    }
}
