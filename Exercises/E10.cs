using System;

namespace Exercises
{
    class E10
    {
        public E10()
        {
            System.Console.Write("Deciliter: ");

            int deciLiter = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Hectoliter: {0}", (double)deciLiter / 1000);
            System.Console.WriteLine("Liter: {0}", (double)deciLiter / 10);
            System.Console.WriteLine("Deciliter: {0}", deciLiter);
        }
    }
}