namespace KitchenCoPilot
{
    public partial class RecipeDetailPage : ContentPage
    {
        private Recipe _recipe;

        public RecipeDetailPage(Recipe recipe)
        {
            InitializeComponent();
            _recipe = recipe ?? throw new ArgumentNullException(nameof(recipe));
            RecipeImage.Source = recipe.StrMealThumb;
            RecipeTitle.Text = recipe.StrMeal;
            RecipeInstructions.Text = recipe.StrInstructions;

            var ingredients = new List<Ingredient>();
            for (int i = 1; i <= 20; i++)
            {
                var ingredientName = (string?)recipe.GetType().GetProperty($"StrIngredient{i}")?.GetValue(recipe);
                var ingredientMeasure = (string?)recipe.GetType().GetProperty($"StrMeasure{i}")?.GetValue(recipe);
                if (!string.IsNullOrEmpty(ingredientName))
                {
                    ingredients.Add(new Ingredient
                    {
                        Name = $"{ingredientMeasure} {ingredientName}",
                        ImageUrl = $"https://www.themealdb.com/images/ingredients/{ingredientName}.png"
                    });
                }
            }
            IngredientsCollectionView.ItemsSource = ingredients;
        }

        
    }

    public class Ingredient
    {
        public string Name { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
    }
}
