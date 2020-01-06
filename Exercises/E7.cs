using System;

namespace Exercises
{
    class E7
    {
        public E7()
        {
            Console.Write("Number 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 2: ");
            int b = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Arithmetic mean of the two given numbers: {0}", (a + b) / 2);
        }
    }
}