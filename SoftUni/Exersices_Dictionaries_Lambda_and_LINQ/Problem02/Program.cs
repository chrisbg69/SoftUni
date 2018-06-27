﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            var phoneBook = new SortedDictionary<string, string>();

            while (command != "END")
            {
                var commandList = command
                    .Split(' ')
                    .ToList();
                var instruction = commandList[0];
                var name = commandList.Count() > 1 ?
                    commandList[1] :
                    string.Empty;

                if (instruction == "A")
                {
                    var phoneNumber = commandList[2];
                    AddToPhoneBook(phoneBook, name, phoneNumber);
                }

                if (instruction == "S")
                {
                    SearchPhoneByName(phoneBook, name);
                }

                if (instruction == "ListAll")
                {
                    PrintPhoneBookEntries(phoneBook);
                }

                command = Console.ReadLine();
            }
        }

        static void AddToPhoneBook(SortedDictionary<string, string> phoneBook, string name, string phoneNumber)
        {
            if (!phoneBook.ContainsKey(name))
            {
                phoneBook[name] = string.Empty;
            }
            phoneBook[name] = phoneNumber;
        }

        static void SearchPhoneByName(SortedDictionary<string, string> phoneBook, string name)
        {
            Console.WriteLine(
                phoneBook.ContainsKey(name) ?
                $"{name} -> {phoneBook[name]}" :
                $"Contact {name} does not exist."
                );
        }

        static void PrintPhoneBookEntries(SortedDictionary<string, string> phoneBook)
        {
            foreach (var item in phoneBook)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
