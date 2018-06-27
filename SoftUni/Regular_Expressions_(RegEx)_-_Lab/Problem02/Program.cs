using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            string toRegex = @"\+359( |\-)2(\1)\d{3}(\1)\d{4}\b";

            string phones = Console.ReadLine();

            MatchCollection solution = Regex.Matches(phones, toRegex);

            string[] matchedPhones = solution
                .Cast<Match>()
                .Select(match => match.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
