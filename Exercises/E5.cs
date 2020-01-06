using System;

namespace Exercises
{
    class E5
    {
        public E5()
        {
            System.Console.Write("Number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            System.Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            System.Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
            System.Console.WriteLine("{0} / {1} = {2}", num1, num2, (double)num1 / num2);
        }
    }
}