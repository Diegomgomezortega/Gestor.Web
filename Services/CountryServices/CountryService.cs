using System.Net.Http.Json;

namespace Gestor.Web.Services.CountryServices
{
    public class CountryService
    {
        private readonly HttpClient _httpClient;

        public CountryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<string>> GetCountries()
        {
            return await _httpClient.GetFromJsonAsync<List<string>>("paises");
        }
    }
}
