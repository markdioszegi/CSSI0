using System;

namespace Exercises
{
    class E20
    {
        public E20()
        {
            int[] coins = { 25, 10, 5, 2, 1 };
            int[] numberOfCoins = new int[coins.Length];
            int amount;

            System.Console.Write("Type in a value: ");
            amount = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < coins.Length; i++)
            {
                numberOfCoins[i] = amount / coins[i];
                amount = amount % coins[i];     //Calculate leftover 
            }

            for (int i = 0; i < numberOfCoins.Length; i++)
            {
                System.Console.WriteLine($"{coins[i]} euro coin(s): {numberOfCoins[i]}");
            }
        }
        ~E20()
        {
            System.Console.WriteLine("Megszűnt! :(");
        }
    }
}