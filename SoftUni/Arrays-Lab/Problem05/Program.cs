using System;
using System.Linq;

namespace Problem05
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] inputArray = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();
            long[] outputArray = (long[])inputArray.Clone();
            outputArray = inputArray
                .Select(element => Math.Round(element, MidpointRounding.AwayFromZero))
                .ToArray();
            foreach (var arrayElement in inputArray.Zip(outputArray, Tuple.Create))
            {
                Console.WriteLine($"{arrayElement.Item1} => {arrayElement.Item2}");
            }
        }
    }
}
