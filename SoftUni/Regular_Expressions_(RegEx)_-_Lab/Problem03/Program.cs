using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem03
{
    class Program
    {
        static void Main(string[] args)
        {
            string toRegex = @"\b(?:0x)?([0-9A-F]+)\b";

            string input = Console.ReadLine();

            string[] solution = Regex.Matches(input, toRegex)
                .Cast<Match>()
                .Select(match => match.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ", solution));
        }
    }
}
