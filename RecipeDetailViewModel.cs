namespace KitchenCoPilot

{
    public class RecipeDetailViewModel
    {
        public Recipe SelectedRecipe { get; set; }

        public RecipeDetailViewModel(Recipe recipe)
        {
            SelectedRecipe = recipe;
        }
    }
}
