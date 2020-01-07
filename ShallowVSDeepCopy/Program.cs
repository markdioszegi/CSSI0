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
                            recipes.Add(new Recipe("R0", "Fried Egg"));
                            recipes[0].AddIngredient("egg");
                        }
                        break;
                    case 1:
                        {
                            recipes.Add(new Recipe("R1", "Air Fryer Balsamic-Glazed Chicken Wings"));
                            recipes[1].AddIngredient("baking powder");
                            recipes[1].AddIngredient("salt");
                            recipes[1].AddIngredient("soy sauce");
                            recipes[1].AddIngredient("honey");
                            recipes[1].AddIngredient("chicken wing");
                        }
                        break;
                    case 2:
                        {
                            recipes.Add(new Recipe("R2", "Sejuani"));
                            recipes[2].AddIngredient("chicken");
                            recipes[2].AddIngredient("rice");
                            recipes[2].AddIngredient("sejuani sauce");
                        }
                        break;
                    case 3:
                        {
                            recipes.Add(new Recipe("R3", "Potato casserole"));
                            recipes[3].AddIngredient("potato");
                            recipes[3].AddIngredient("egg");
                            recipes[3].AddIngredient("cheese");
                            recipes[3].AddIngredient("sour cream");
                            recipes[3].AddIngredient("sausage");
                        }
                        break;
                    case 4:
                        {
                            recipes.Add(new Recipe("R4", "Gyros"));
                            recipes[4].AddIngredient("chicken thighs fillets");
                            recipes[4].AddIngredient("olive");
                            recipes[4].AddIngredient("gyros spices");
                        }
                        break;
                    default:
                        {
                            recipes.Add(new Recipe("RX", "Mac n Cheese"));
                            recipes[5].AddIngredient("mac");
                            recipes[5].AddIngredient("cheese");
                        }
                        break;
                }
            }

            clonedRecipes.Add((Recipe)recipes[0].ShallowCopy());    //shallow

            System.Console.WriteLine("\t[Shallow Copy] Originals: ");
            Console.WriteLine(recipes[0].ToString());
            Console.WriteLine(clonedRecipes[0].ToString());

            recipes[0].name = "Fried egg without egg";
            recipes[0].RemoveIngredient("egg");

            System.Console.WriteLine("\t[Shallow Copy] After changing first: ");
            Console.WriteLine(recipes[0].ToString());
            Console.WriteLine(clonedRecipes[0].ToString());

            //deep

            Recipe rec = new Recipe("LA", "Lasagne");
            rec.AddIngredient("cheese");
            rec.AddIngredient("meat");

            Recipe recDeepCopy = rec.DeepCopy();

            System.Console.WriteLine("\t[Deep Copy] Originals: ");
            System.Console.WriteLine(rec.ToString());
            System.Console.WriteLine(recDeepCopy.ToString());

            rec.name = "Cheesy cheese";
            rec.RemoveIngredient("cheese");

            System.Console.WriteLine("\t[Deep Copy] After changing first: ");
            System.Console.WriteLine(rec.ToString());
            System.Console.WriteLine(recDeepCopy.ToString());
        }
    }
}
