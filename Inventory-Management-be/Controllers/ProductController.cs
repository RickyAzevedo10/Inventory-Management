using Inventory_Managment.Application.Interfaces;
using Inventory_Managment.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace Inventory_Managment_be.Controllers
{
    /// <summary>
    /// API controller that handles product-related endpoints.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductHandler _productService;

        public ProductController(IProductHandler productService)
        {
            _productService = productService;
        }

        /// <summary>
        /// Creates a new product.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductRequest request)
        {
            await _productService.CreateProductAsync(request);
            return StatusCode(201, new { message = "Product created successfully" });
        }

        //Create product
        //List products(with pagination, sorting, and filtering)
        //Get product details
        //Update product
        //Delete product
    }
}
