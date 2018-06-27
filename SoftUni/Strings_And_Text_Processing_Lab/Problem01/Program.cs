using System;
using System.Linq;

namespace Problem01
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            var reversedCharArray = words.ToCharArray().Reverse();
            Console.WriteLine(string.Join("", reversedCharArray));

        }
    }
}
