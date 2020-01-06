using System;

namespace Exercises
{
    class E19
    {
        public E19()
        {
            bool withCup = true;
            bool doubleSugar = false;
            string coffeeID = "";

            System.Console.WriteLine("Which coffee do you want? (1: Espresso) (2: Espresso with extra cream)");
            if (Console.ReadLine() == "1")
            {
                coffeeID = "espresso";
            }
            else
            {
                coffeeID = "espressoextra";
            }
            System.Console.WriteLine("With cup or without? (\"with\" or \"without\")");
            if (Console.ReadLine() == "without")
            {
                withCup = false;
            }
            System.Console.WriteLine("Double sugar? (\"yes\" or \"no\")");
            if (Console.ReadLine() == "yes")
            {
                doubleSugar = true;
            }

            System.Console.WriteLine($"it will be {CalculatePrice(coffeeID, doubleSugar, withCup)} HUF.");
        }

        int CalculatePrice(string coffeeID, bool doubleSugar, bool withCup)
        {
            int price = 80;
            if (coffeeID == "espressoextra") { price += 50; }
            if (doubleSugar) { price += 20; }
            if (!withCup) { price -= 10; }
            return price;
        }
    }
}