namespace KitchenCoPilot
{
    public partial class ShoppingCartPage : ContentPage
    {
        public ShoppingCartPage(List<Ingredient> ingredients)
        {
            InitializeComponent();
            BindingContext = new ShoppingCartViewModel(ingredients);
        }

        private async void OnSaveCartButtonClicked(object sender, EventArgs e)
        {
            var viewModel = BindingContext as ShoppingCartViewModel;
            if (viewModel != null)
            {
                ShoppingCartService.SaveIngredients(viewModel.Ingredients.ToList());
                await DisplayAlert("Shopping Cart", "Shopping cart saved successfully!", "OK");
                await Navigation.PushAsync(new SavedCartPage());
            }
        }

        private async void OnViewSavedCartButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SavedCartPage());
        }
    }
}
