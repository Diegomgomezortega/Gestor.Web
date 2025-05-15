using Gestor.Web.DTOs.Request.Category;
using Gestor.Web.DTOs.Response.Category;
using System.Net.Http.Json;

namespace Gestor.Web.Services.CategoryServices
{
    public class CategoryService
    {
        private readonly HttpClient _httpClient;

        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<CategoryResponse?> GetCategoryByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<CategoryResponse>($"categorias/{id}");
        }
        public async Task<List<CategoryResponse>> GetCategories()
        {
            return await _httpClient.GetFromJsonAsync<List<CategoryResponse>>("categorias");
        }
        public async Task<int> CreateCategory(AddCategoryRequest category)
        {
            var response = await _httpClient.PostAsJsonAsync("categorias", category);
            return response.IsSuccessStatusCode ? 1 : 0;
        }
        public async Task UpdateCategory(AddCategoryRequest category, int id)
        {
            await _httpClient.PutAsJsonAsync($"categorias/{id}", category);
        }
        public async Task<bool> DeleteCategory(int id)
        {
            var response= await _httpClient.DeleteAsync($"categorias/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
