using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace KitchenCoPilot
{
    public class RecipeViewModel
    {
        private readonly RecipeApiService _recipeApiService;

        public ObservableCollection<Recipe> Recipes { get; set; }

        public RecipeViewModel()
        {
            _recipeApiService = new RecipeApiService();
            Recipes = new ObservableCollection<Recipe>();
        }

        public async Task SearchRecipesAsync(string name)
        {
            var recipes = await _recipeApiService.SearchRecipesByNameAsync(name);
            Recipes.Clear();
            foreach (var recipe in recipes)
            {
                Recipes.Add(recipe);
            }
        }

        public async Task FilterRecipesByIngredientAsync(string ingredient)
        {
            var recipes = await _recipeApiService.FilterRecipesByIngredientAsync(ingredient);
            Recipes.Clear();
            foreach (var recipe in recipes)
            {
                Recipes.Add(recipe);
            }
        }

        public async Task FilterRecipesByCategoryAsync(string category)
        {
            var recipes = await _recipeApiService.FilterRecipesByCategoryAsync(category);
            Recipes.Clear();
            foreach (var recipe in recipes)
            {
                Recipes.Add(recipe);
            }
        }

        public async Task FilterRecipesByAreaAsync(string area)
        {
            var recipes = await _recipeApiService.FilterRecipesByAreaAsync(area);
            Recipes.Clear();
            foreach (var recipe in recipes)
            {
                Recipes.Add(recipe);
            }
        }
    }
}