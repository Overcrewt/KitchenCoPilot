using KitchenCoPilot.Models;
using KitchenCoPilot.Views; // Assuming ShoppingListPage is in the Views namespace

namespace KitchenCoPilot.Views // Ensure this matches the namespace of your XAML file
{
    public partial class RecipeDetailPage : ContentPage
    {
        private Recipe _recipe;

        public RecipeDetailPage(Recipe recipe)
        {
            InitializeComponent();
            _recipe = recipe;
            BindingContext = _recipe;
        }

        private async void OnViewShoppingListClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShoppingListPage(_recipe));
        }
    }
}
