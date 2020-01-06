using System;

namespace Exercises
{
    class E16
    {
        public E16()
        {
            string password = "asd";
            const int maxAttempts = 3;
            int attempts = 0;
            bool accepted = false;

            while (!accepted)
            {
                attempts++;
                System.Console.Write("Enter the password: ");

                if (Console.ReadLine() != password)
                {
                    System.Console.WriteLine("Wrong password!");
                }
                else
                {
                    System.Console.WriteLine("Correct password!");
                    accepted = true;
                }
                if (attempts >= maxAttempts)
                {
                    System.Console.WriteLine("Too many attempts!");
                    System.Environment.Exit(0);
                }
            }
        }
    }
}