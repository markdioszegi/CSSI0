using System;

namespace Exercises
{
    class E17
    {
        public E17()
        {
            System.Console.Write("Type in a month's number: ");
            int monthNumber = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine(GetSeason(monthNumber));
        }
        /// <summary>
        /// Gives back the season by the given month
        /// </summary>
        /// <param name="month"></param>
        string GetSeason(int monthNumber)
        {
            if (monthNumber == 12 || monthNumber == 1 || monthNumber == 2)
                return "Winter";
            if (monthNumber > 2 && monthNumber < 6)
                return "Spring";
            if (monthNumber > 5 && monthNumber < 9)
                return "Summer";
            if (monthNumber > 8 && monthNumber < 12)
                return "Autumn";
            throw new Exception("Wrong month!");
        }
    }
}