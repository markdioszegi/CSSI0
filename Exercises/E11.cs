using System;

namespace Exercises
{
    class E11
    {
        public E11()
        {
            System.Console.Write("Number: ");

            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 9 == 0)
            {
                System.Console.WriteLine("{0} can be divided by 9.", num);
            }
            else
            {
                System.Console.WriteLine("{0} can't be divided by 9.", num);
            }
        }
    }
}