namespace KitchenCoPilot
{
    public partial class SavedCartPage : ContentPage
    {
        public SavedCartPage()
        {
            InitializeComponent();
            BindingContext = new SavedCartViewModel();
        }

        private void OnClearCartButtonClicked(object sender, EventArgs e)
        {
            var viewModel = BindingContext as SavedCartViewModel;
            viewModel?.ClearCart();
        }
    }
}
