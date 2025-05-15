using Gestor.Web.DTOs.Request.Product;
using Gestor.Web.DTOs.Response.Product;
using System.Net.Http.Json;

namespace Gestor.Web.Services.ProductServices
{
    public class ProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<GetProductResponse>?> GetProductsAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<List<GetProductResponse>>("productos");

            return response;
        }
        public async Task<GetProductResponse?> GetProductByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<GetProductResponse>($"productos/{id}");
        }
        public async Task<int> CreateProductAsync(ProductRequest producto)
        {
            var response = await _httpClient.PostAsJsonAsync("productos", producto);
            return response.IsSuccessStatusCode ? 1 : 0;
        }
        public async Task UpdateProductAsync(ProductRequest producto, int id)
        {
            await _httpClient.PutAsJsonAsync($"productos/{id}", producto);
        }
        public async Task DeleteProductAsync(int id)
        {
            await _httpClient.DeleteAsync($"productos/{id}");
        }
    }
}
