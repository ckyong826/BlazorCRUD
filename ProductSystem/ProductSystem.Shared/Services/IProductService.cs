using ProductSystem.Shared.Entity;

namespace ProductSystem.Shared.Services
{
	public interface IProductService
	{
		Task<List<Product>> GetAllProducts();
		Task<Product> CreateProduct(Product product);
	}
}
