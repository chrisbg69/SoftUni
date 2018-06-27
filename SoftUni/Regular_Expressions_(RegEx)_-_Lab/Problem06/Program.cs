﻿using System;
using System.Text.RegularExpressions;

namespace Problem06
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string toRegex = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
            string replacement = @"[URL href=$1]$2[/URL]";

            while (input != "end")
            {
                string replaced = Regex.Replace(input, toRegex, replacement);

                Console.WriteLine(replaced);

                input = Console.ReadLine();
            }

            //List<string> solution = new List<string>();

            //while (input != "end")
            //{
            //    if (input.Contains("<a"))
            //    {
            //        input = input.Replace("<a", "[URL");
            //        input = input.Replace(">", "]");
            //        input = input.Replace("</a>", "[/URL]");
            //    }
            //    solution.Add(input);
            //    input = Console.ReadLine();
            //}
            //foreach (var word in solution)
            //{
            //    Console.WriteLine(word);
            //}
        }
    }
}
