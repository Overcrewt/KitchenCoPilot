using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace KitchenCoPilot
{
    public class ShoppingCartViewModel
    {
        public ObservableCollection<Ingredient> Ingredients { get; set; }

        public ShoppingCartViewModel(List<Ingredient> ingredients)
        {
            Ingredients = new ObservableCollection<Ingredient>(ingredients);
        }

        public void AddIngredients(List<Ingredient> newIngredients)
        {
            foreach (var ingredient in newIngredients)
            {
                if (!Ingredients.Any(i => i.Name == ingredient.Name))
                {
                    Ingredients.Add(ingredient);
                }
            }
        }
    }

    public class Ingredient
    {
        public string Name { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public bool IsSelected { get; set; }
    }
}