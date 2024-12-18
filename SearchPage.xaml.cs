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

        private async void OnRecipeSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is Recipe selectedRecipe)
            {
                await Navigation.PushAsync(new RecipeDetailPage(selectedRecipe));
            }
        }
    }
}