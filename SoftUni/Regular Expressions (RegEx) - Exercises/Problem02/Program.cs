using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyWord = Console.ReadLine();
            string pattern = $@"\b{keyWord}\b"; //cool regex 100/100
            Regex regex = new Regex(pattern);

            string[] words = Console.ReadLine()
                .Split(new[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim())
                .ToArray();

            foreach (string word in words)
            {
                if (regex.IsMatch(word))
                {
                    Console.WriteLine(word);
                }
            }


        }
    }
}
