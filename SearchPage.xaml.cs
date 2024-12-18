namespace KitchenCoPilot
{
    public partial class SearchPage : ContentPage
    {
        private RecipeViewModel ViewModel => BindingContext as RecipeViewModel;

        public SearchPage()
        {
            InitializeComponent();
        }

        private async void OnSearchButtonClicked(object sender, EventArgs e)
        {
            if (ViewModel != null)
            {
                await ViewModel.SearchRecipesAsync(RecipeSearchBar.Text);
            }
        }

        private void OnFilterButtonClicked(object sender, EventArgs e)
        {
            FilterGrid.IsVisible = !FilterGrid.IsVisible;
        }

        private async void OnFilterByIngredientClicked(object sender, EventArgs e)
        {
            if (ViewModel != null)
            {
                await ViewModel.FilterRecipesByIngredientAsync(IngredientEntry.Text);
                FilterGrid.IsVisible = false;
            }
        }

        private async void OnFilterByCategoryClicked(object sender, EventArgs e)
        {
            if (ViewModel != null)
            {
                await ViewModel.FilterRecipesByCategoryAsync(CategoryEntry.Text);
                FilterGrid.IsVisible = false;
            }
        }

        private async void OnFilterByAreaClicked(object sender, EventArgs e)
        {
            if (ViewModel != null)
            {
                await ViewModel.FilterRecipesByAreaAsync(AreaEntry.Text);
                FilterGrid.IsVisible = false;
            }
        }

        private async void OnRecipeSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is Recipe selectedRecipe)
            {
                await Navigation.PushAsync(new RecipeDetailPage(selectedRecipe));
            }
        }
    }
}
