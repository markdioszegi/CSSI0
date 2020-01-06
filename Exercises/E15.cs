using System;

namespace Exercises
{
    class E15
    {
        public E15()
        {
            System.Console.Write("Beszélsz magyarul? ");
            string answer = Console.ReadLine();
            if (answer.ToLower().Contains("igen"))
            {
                System.Console.WriteLine("Szia!");
            }
            else
            {
                System.Console.Write("Do you speak english? ");
                answer = Console.ReadLine();
                if (answer.ToLower().Contains("yes"))
                {
                    System.Console.WriteLine("Hi there!");
                }
                else
                {
                    System.Console.Write("Habla español? ");
                    answer = Console.ReadLine();
                    if (answer.ToLower().Contains("sí"))
                    {
                        System.Console.WriteLine("¡Hola");
                    }
                    else
                    {
                        System.Console.WriteLine("❤");
                    }
                }
            }
        }
    }
}