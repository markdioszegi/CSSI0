using System;

namespace Exercises
{
    class E12
    {
        public E12()
        {
            System.Console.Write("Number: ");
            long num = Convert.ToInt64(Console.ReadLine());
            int divider = 1;
            int digits = 0;

            if (!(num >= 0)) { System.Console.WriteLine("Number is negative!"); }

            while (divider < num)
            {
                divider *= 10;
                digits++;
            }

            System.Console.WriteLine("{0} consists of {1} digit(s).", num, digits);
        }
    }
}