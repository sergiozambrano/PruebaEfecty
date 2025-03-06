using System.Text;
using System.Text.Json;
using VistaEfecty.Models;

namespace VistaEfecty.Service
{
    public class HttpServices(HttpClient httpClient)
    {
        private readonly HttpClient _httpClient = httpClient;
        private readonly JsonSerializerOptions _jsonOptions = new() { PropertyNameCaseInsensitive = true };

        public async Task<List<Prueba>?> GetPruebaAsync()
        {
            var response = await _httpClient.GetAsync("Efecty");

            if (!response.IsSuccessStatusCode) 
                return null;

            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<Prueba>?>(json, _jsonOptions);
        }

        public async Task<bool> AddPruebaAsync(Prueba data)
        {
            var content = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("Efecty", content);

            return response.IsSuccessStatusCode;
        }
    }
}
