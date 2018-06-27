using System;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double pi = Math.PI;
            double area = pi * radius * radius;

            Console.WriteLine($"{area:f12}");
        }
    }
}
