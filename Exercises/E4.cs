using System;

namespace Exercises
{
    class E4
    {
        public E4()
        {
            System.Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (num > 0)
                {
                    Console.WriteLine("{0} is a positive number.", num);
                }
                else
                {
                    Console.WriteLine("{0} is a negative number.", num);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Type mismatch!");
            }
        }
    }
}