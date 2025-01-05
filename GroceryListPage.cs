using KitchenCoPilot.Models;
using KitchenCoPilot.ViewModels;

namespace KitchenCoPilot
{
    public partial class GroceryListPage : ContentPage
    {
        public GroceryListPage(Recipe recipe)
        {
            InitializeComponent();
            BindingContext = new GroceryListViewModel(recipe);
        }
    }
}

