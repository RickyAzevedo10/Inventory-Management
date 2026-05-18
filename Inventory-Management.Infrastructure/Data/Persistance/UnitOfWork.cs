using Inventory_Managment.Domain.Interfaces;
using Inventory_Managment.Infrastructure.Data.Repositories;

namespace Inventory_Managment.Infrastructure.Data.Persistance
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }

        public IProductRepository _productRepository { get; private set; }

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
