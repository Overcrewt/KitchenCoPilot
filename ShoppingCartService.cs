using System.Collections.Generic;

namespace KitchenCoPilot
{
    public static class ShoppingCartService
    {
        private static List<Ingredient> savedIngredients = new List<Ingredient>();

        public static void SaveIngredients(List<Ingredient> ingredients)
        {
            savedIngredients = new List<Ingredient>(ingredients);
        }

        public static List<Ingredient> GetSavedIngredients()
        {
            return savedIngredients;
        }

        public static void ClearSavedIngredients()
        {
            savedIngredients.Clear();
        }
    }
}
