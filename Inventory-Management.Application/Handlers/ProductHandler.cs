using Inventory_Managment.Application.Interfaces;
using Inventory_Managment.Domain.Interfaces;

namespace Inventory_Managment.Application.Services
{
    public class ProductHandler : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
