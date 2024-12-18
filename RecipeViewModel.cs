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
    }
}