using System;

namespace Exercises
{
    class E18
    {
        public E18()
        {
            string[] months = { "January", "February", "March", "April", "May",
            "June", "July", "August", "September", "October", "November", "December" };
            int[] averageTemperatures = new int[12];

            for (int i = 0; i < months.Length; i++)
            {
                System.Console.Write($"Average temperature in {months[i]}: ");
                averageTemperatures[i] = Convert.ToInt32(Console.ReadLine());
            }

            System.Console.WriteLine($"The average annual temperature is: {AverageAnnualTemperature(averageTemperatures)}");
        }

        double AverageAnnualTemperature(int[] averageTemperatures)
        {
            int sum = 0;
            for (int i = 0; i < averageTemperatures.Length; i++)
            {
                sum += averageTemperatures[i];
            }
            return Math.Round((double)sum / averageTemperatures.Length, 2);
        }
    }
}