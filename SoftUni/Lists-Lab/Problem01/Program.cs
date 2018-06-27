using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem01
{
    class Program
    {
        static void Main(string[] args)
        {
            var numList = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .Where(n => n >= 0)
                 .Reverse()
                 .ToList();
            Console.WriteLine(
                numList.Count == 0 ?
                "empty" :
                string.Join(" ", numList)
                );

        }
    }
}
