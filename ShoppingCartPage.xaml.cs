namespace KitchenCoPilot
{
    public partial class ShoppingCartPage : ContentPage
    {
        public ShoppingCartPage(List<Ingredient> ingredients)
        {
            InitializeComponent();
            BindingContext = new ShoppingCartViewModel(ingredients);
        }

        private void OnSaveCartButtonClicked(object sender, EventArgs e)
        {
            var viewModel = BindingContext as ShoppingCartViewModel;
            if (viewModel != null)
            {
                // Save the state of the shopping cart (e.g., to a file, database, or preferences)
                // This is a placeholder for the actual save logic
                DisplayAlert("Shopping Cart", "Shopping cart saved successfully!", "OK");
            }
        }
    }
}