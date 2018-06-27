using System;

namespace Problem01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            NameOf();

        }

        private static void NameOf()
        {
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
