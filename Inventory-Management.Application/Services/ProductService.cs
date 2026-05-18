using Inventory_Managment.Application.Interfaces;
using Inventory_Managment.Domain.Interfaces;

namespace Inventory_Managment.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
