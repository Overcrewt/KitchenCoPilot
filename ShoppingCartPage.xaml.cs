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
                DisplayAlert("Shopping Cart", "Shopping cart saved successfully!", "OK");
            }
        }
    }
}
