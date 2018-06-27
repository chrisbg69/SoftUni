using System;
using System.Linq;

namespace Problem06
{
    class Program
    {
        static void Main(string[] args)
        {
            var numList = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .Where(n => Math.Sqrt(n) == (int)Math.Sqrt(n))
                 .OrderByDescending(n => n)
                 .ToList();
            Console.WriteLine(string.Join(" ", numList));
        }
    }
}
