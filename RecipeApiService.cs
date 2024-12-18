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

        public async Task<List<Recipe>> FilterRecipesByIngredientAsync(string ingredient)
        {
            var response = await _httpClient.GetFromJsonAsync<RecipeResponse>($"filter.php?i={ingredient}");
            return response?.Meals ?? new List<Recipe>();
        }

        public async Task<List<Recipe>> FilterRecipesByCategoryAsync(string category)
        {
            var response = await _httpClient.GetFromJsonAsync<RecipeResponse>($"filter.php?c={category}");
            return response?.Meals ?? new List<Recipe>();
        }

        public async Task<List<Recipe>> FilterRecipesByAreaAsync(string area)
        {
            var response = await _httpClient.GetFromJsonAsync<RecipeResponse>($"filter.php?a={area}");
            return response?.Meals ?? new List<Recipe>();
        }
    }

    public class RecipeResponse
    {
        public List<Recipe> Meals { get; set; }
    }
}