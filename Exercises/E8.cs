using System;

namespace Exercises
{
    class E8
    {
        public E8()
        {
            System.Console.Write("Side a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Side b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Side c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("e diagonal (a and b): {0}", Math.Sqrt((a * a) + (b * b)));
            System.Console.WriteLine("f diagonal (c and b): {0}", Math.Sqrt((c * c) + (b * b)));
            System.Console.WriteLine("g diagonal (a and c): {0}", Math.Sqrt((a * a) + (c * c)));
            System.Console.WriteLine("Space diagonal: {0}", Math.Sqrt((a * a) + (b * b) + (c * c)));
            System.Console.WriteLine("Surface: {0}", 2 * ((a * b) + (a * c) + (b * c)));
            System.Console.WriteLine("Volume: {0}", (a * b * c));
        }
    }
}