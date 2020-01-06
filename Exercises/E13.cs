using System;

namespace Exercises
{
    class E13
    {
        public E13()
        {
            System.Console.Write("Type in a month: ");
            string month = Console.ReadLine();

            if (month.ToLower().Contains("december") || month.ToLower().Contains("january") || month.ToLower().Contains("february"))
                System.Console.WriteLine("It's winter!");
            if (month.ToLower().Contains("march") || month.ToLower().Contains("april") || month.ToLower().Contains("may"))
                System.Console.WriteLine("It's Spring!");
            if (month.ToLower().Contains("june") || month.ToLower().Contains("july") || month.ToLower().Contains("august"))
                System.Console.WriteLine("It's Summer! ;)");
            if (month.ToLower().Contains("september") || month.ToLower().Contains("october") || month.ToLower().Contains("november"))
                System.Console.WriteLine("It's Autumn!");
        }
    }
}