using System;

namespace Problem09
{
    class Program
    {
        static void Main(string[] args)
        {
            int wordSize = int.Parse(Console.ReadLine());
            char[] wordLetters = new char[wordSize];

            for (int i = 0; i < wordSize; i++)
            {
                wordLetters[i] = char.Parse(Console.ReadLine());
            }

            string word = new string(wordLetters);
            Console.WriteLine($"The word is: {word}");


        }
    }
}
