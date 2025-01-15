namespace KitchenCoPilot
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(RecipeDetailPage), typeof(RecipeDetailPage));
            Routing.RegisterRoute(nameof(ShoppingCartPage), typeof(ShoppingCartPage));
        }

        protected override void OnNavigated(ShellNavigatedEventArgs args)
        {
            base.OnNavigated(args);

            if (args.Current.Location.OriginalString.Contains(nameof(ShoppingCartPage)))
            {
                // Remove the shopping cart button if on the ShoppingCartPage
                ToolbarItems.Clear();
            }
            else
            {
                // Add the shopping cart button if not on the ShoppingCartPage
                if (ToolbarItems.All(t => t.Text != "Cart"))
                {
                    ToolbarItems.Add(new ToolbarItem
                    {
                        Text = "Cart",
                        Command = new Command(async () => await GoToShoppingCart())
                    });
                }
            }
        }

        private async Task GoToShoppingCart()
        {
            await Shell.Current.GoToAsync(nameof(ShoppingCartPage));
        }
    }
}