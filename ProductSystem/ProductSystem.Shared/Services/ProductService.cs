
using ProductSystem.Shared.Data;
using ProductSystem.Shared.Entity;
using Microsoft.EntityFrameworkCore;
namespace ProductSystem.Shared.Services
{
	public class ProductService : IProductService
	{
		private readonly DataContext _context;

		public ProductService(DataContext context)
		{
			_context = context;
		}
		public async Task<List<Product>> GetAllProducts()
		{
			await Task.Delay(1000);
			var products = await _context.Products.ToListAsync();
			return products;
		}

		public async Task<Product> CreateProduct(Product product)
		{
			_context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }
	}

}
