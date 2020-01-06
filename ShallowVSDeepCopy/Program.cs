using System;
using System.Collections.Generic;

namespace SI0
{
    public class Program
    {
        public static void Main(String[] args)
        {
            List<Recipe> recipes = new List<Recipe>();
            List<Recipe> clonedRecipes = new List<Recipe>();

            for (int i = 0; i < 5; i++)
            {
                switch (i)
                {
                    case 0:
                        {
                            recipes.Add(new Recipe("R0", "Fried Egg", new List<String>() { "egg" }));
                        }
                        break;
                    case 1:
                        {
                            recipes.Add(new Recipe("R1", "Air Fryer Balsamic-Glazed Chicken Wings", new List<String>()
                            { "baking powder", "salt", "soy sauce", "honey", "chicken wing" }));
                        }
                        break;
                    case 2:
                        {
                            recipes.Add(new Recipe("R2", "Sejuani", new List<String>() { "chicken", "rice", "sejuani sauce" }));
                        }
                        break;
                    case 3:
                        {
                            recipes.Add(new Recipe("R3", "Potato casserole", new List<string>()
                            { "potato", "egg", "cheese", "sour cream", "sausage" }));
                        }
                        break;
                    case 4:
                        {
                            recipes.Add(new Recipe("R4", "Gyros", new List<String>() { "chicken thighs fillets", "olive", "gyros spices" }));
                        }
                        break;
                    default:
                        {
                            recipes.Add(new Recipe("RX", "Mac n Cheese", new List<string>() { "mac", "cheese" }));
                        }
                        break;
                }
            }

            clonedRecipes.Add((Recipe)recipes[0].ShallowCopy());
            clonedRecipes.Add((Recipe)recipes[2].ShallowCopy());
            clonedRecipes.Add((Recipe)recipes[4].ShallowCopy());

            System.Console.WriteLine("[!]---Before changing: ");
            Console.WriteLine(recipes[0].ToString());
            Console.WriteLine(recipes[2].ToString());
            Console.WriteLine(recipes[4].ToString());

            clonedRecipes[0].name = "Fried egg without egg";
            clonedRecipes[0].ingredients.Remove("egg");
            clonedRecipes[1].name = "Sejuani with extra sauce";
            clonedRecipes[1].ingredients.Add("more sauce");
            clonedRecipes[2].name = "Vegan Gyros";
            clonedRecipes[2].ingredients.Remove("chicken thighs fillets");


            System.Console.WriteLine("[!]---After changing: ");
            Console.WriteLine(recipes[0].ToString());
            Console.WriteLine(recipes[2].ToString());
            Console.WriteLine(recipes[4].ToString());
            Console.WriteLine(clonedRecipes[0].ToString());
            Console.WriteLine(clonedRecipes[1].ToString());
            Console.WriteLine(clonedRecipes[2].ToString());
        }
    }
}
