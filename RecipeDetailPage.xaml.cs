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

        private async void OnViewIngredientsButtonClicked(object sender, EventArgs e)
        {
            var ingredients = IngredientsCollectionView.ItemsSource.Cast<Ingredient>().ToList();
            var shoppingCartPage = new ShoppingCartPage(ingredients);
            await Navigation.PushAsync(shoppingCartPage);
        }

        private async void OnViewSavedCartButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SavedCartPage());
        }
    }
}
