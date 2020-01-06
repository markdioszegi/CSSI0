using System;

namespace Exercises
{
    class E14
    {
        public E14()
        {
            string[] months = { "January", "February", "March", "April", "May",
            "June", "July", "August", "September", "October", "November", "December" };
            int[] income = new int[12];
            int[] expenses = new int[12];
            int sum = 0;

            for (int i = 0; i < 12; i++)
            {
                System.Console.Write($"Income in {months[i]}: ");
                income[i] = Convert.ToInt32(Console.ReadLine());
                System.Console.Write($"Expenses in {months[i]}: ");
                expenses[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < months.Length; i++)
            {
                sum += income[i] - expenses[i];
            }

            if (sum > 0)
            {
                System.Console.WriteLine("The company is profitable in that year! :)");
            }
            else if (sum < 0)
            {
                System.Console.WriteLine("The company is loss-making in that year! :(");
            }
            else
            {
                System.Console.WriteLine("The company is break-even in that year! :|");

            }
        }
    }
}