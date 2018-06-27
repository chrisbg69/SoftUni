using System;
using System.Linq;

namespace Problem06
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputStrArrReverced = Console.ReadLine()
                .Split(' ')
                .ToArray()
                .Reverse()
                .ToArray();
            Console.WriteLine(string.Join(" ", inputStrArrReverced));
        }
    }
}
