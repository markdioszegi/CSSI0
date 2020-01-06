using System;

namespace Exercises
{
    class E1
    {
        public E1()
        {
            System.Console.Write("Radius: ");
            double r = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Circumference: " + Circumference(r));
            System.Console.WriteLine("Area: " + Area(r));
            System.Console.WriteLine("Volume: " + Volume(r));
            System.Console.WriteLine("Surface: " + Surface(r));
        }

        double Circumference(double r)
        {
            return Math.Round((r * 2) * Math.PI, 2);
        }

        double Area(double r)
        {
            return Math.Round((r * r) * Math.PI, 2);
        }

        double Volume(double r)
        {
            return Math.Round(4 * Math.PI * Math.Pow(r, 3) / 3, 2);
        }

        double Surface(double r)
        {
            return Math.Round(4 * Math.PI * r * r, 2);
        }
    }
}