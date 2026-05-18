using Inventory_Managment.Domain.Interfaces;
using Inventory_Managment.Infrastructure.Data.Repositories;

namespace Inventory_Managment.Infrastructure.Data.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }

        private IProductRepository _productRepository = null!;

        public async Task<bool> CommitAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public IProductRepository ProductRepository
        {
            get
            {
                if (_productRepository == null)
                {
                    _productRepository = new ProductRepository(_context);
                }
                return _productRepository;
            }
        }
    }
}
