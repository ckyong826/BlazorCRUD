using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using ProductSystem.Shared.Entity;


namespace ProductSystem.Shared.Services
{
    public class ClientProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ClientProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<Product> CreateProduct(Product product)
        {
            var result = await _httpClient.PostAsJsonAsync("api/product", product);
            return await result.Content.ReadFromJsonAsync<Product>();
        }

        public Task<List<Product>> GetAllProducts()
        {
            throw new NotImplementedException();
        }

    }
}
