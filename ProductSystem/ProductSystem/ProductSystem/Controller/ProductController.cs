using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductSystem.Shared.Entity;
using ProductSystem.Shared.Services;


namespace ProductSystem.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public async Task<ActionResult<Product>> CreateProduct(Product product)
        {
            var newProduct = await _productService.CreateProduct(product);
            return CreatedAtAction("GetProduct", new { id = newProduct.Id }, newProduct);
        }
    }
}
