using System.Collections.ObjectModel;
using KitchenCoPilot.Models;

namespace KitchenCoPilot.ViewModels
{
    public class GroceryListViewModel
    {
        public Recipe Recipe { get; set; }
        public ObservableCollection<Ingredient> Ingredients { get; set; }

        public GroceryListViewModel(Recipe recipe)
        {
            Recipe = recipe;
            Ingredients = new ObservableCollection<Ingredient>
            {
                new Ingredient { Name = recipe.StrIngredient1, Quantity = recipe.StrMeasure1 },
                new Ingredient { Name = recipe.StrIngredient2, Quantity = recipe.StrMeasure2 },
                new Ingredient { Name = recipe.StrIngredient3, Quantity = recipe.StrMeasure3 },
                // Add more ingredients as needed
            };
        }
    }

    public class Ingredient
    {
        public string Name { get; set; }
        public string Quantity { get; set; }
    }
}

