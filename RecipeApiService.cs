using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace KitchenCoPilot
{
    public class RecipeApiService
    {
        private readonly HttpClient _httpClient;

        public RecipeApiService()
        {
            _httpClient = new HttpClient { BaseAddress = new Uri("https://www.themealdb.com/api/json/v1/1/") };
        }

        public async Task<List<Recipe>> SearchRecipesByNameAsync(string name)
        {
            var response = await _httpClient.GetFromJsonAsync<RecipeResponse>($"search.php?s={name}");
            return response?.Meals ?? new List<Recipe>();
        }

        // Add other methods for different API endpoints as needed
    }

    public class RecipeResponse
    {
        public List<Recipe> Meals { get; set; }
    }
}
