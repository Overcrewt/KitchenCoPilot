using System.Collections.ObjectModel;

namespace KitchenCoPilot
{
    public class SavedCartViewModel
    {
        public ObservableCollection<Ingredient> SavedIngredients { get; set; }

        public SavedCartViewModel()
        {
            SavedIngredients = new ObservableCollection<Ingredient>(ShoppingCartService.GetSavedIngredients());
        }

        public void ClearCart()
        {
            ShoppingCartService.ClearSavedIngredients();
            SavedIngredients.Clear();
        }
    }
}
