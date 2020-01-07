using System;
using System.Collections.Generic;

namespace SI0
{
    public class Recipe
    {
        public String ID, name;
        public List<Ingredient> ingredients;

        public Recipe(String ID, String name)
        {
            this.ID = ID;
            this.name = name;
            ingredients = new List<Ingredient>();
        }

        public override String ToString()
        {
            String _ingredients = "";
            for (int i = 0; i < ingredients.Count; i++)
            {
                if (i != ingredients.Count - 1)
                {
                    _ingredients += ingredients[i].Name + ", ";
                }
                else
                {
                    _ingredients += ingredients[i].Name;
                }
            }
            return String.Format("{0} ({1})\nIngredients: {2}", name, ID, _ingredients);
        }

        /*
        * public void addIngredient(String newIngredient) { String[] _ingredients = new
        * String[ingredients.length + 1]; for (int i = 0; i < ingredients.length; i++)
        * { _ingredients[i] = ingredients[i]; } _ingredients[ingredients.length] =
        * newIngredient; ingredients = _ingredients; }
        * 
        * public void removeIngredient(String ingredient) { if (ingredients.length > 1)
        * { String[] _ingredients = new String[ingredients.length - 1]; for (int i = 0;
        * i < ingredients.length; i++) { if (ingredient != ingredients[i]) {
        * _ingredients[i] = ingredients[i]; } } ingredients = _ingredients; } else {
        * throw new Error("Can not delete the last ingredient!"); } }
        */
        public void AddIngredient(string ingredient)
        {
            ingredients.Add(new Ingredient(ingredient));
        }
        public void RemoveIngredient(string ingredientToRemove)
        {
            foreach (var ingredient in ingredients)
            {
                if (ingredient.Name == ingredientToRemove)
                {
                    ingredients.Remove(ingredient);
                    break;
                }
            }
        }
        public Recipe ShallowCopy()
        {
            return (Recipe)this.MemberwiseClone();
        }

        public Recipe DeepCopy()
        {
            Recipe deepCopyRecipe = (Recipe)this.MemberwiseClone();
            deepCopyRecipe.ingredients = new List<Ingredient>(ingredients);
            return deepCopyRecipe;
        }
    }
}