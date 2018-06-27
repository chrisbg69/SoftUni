using System;
using System.Collections.Generic;

namespace Problem03
{
    class Program
    {
        static void Main(string[] args)
        {
            var minedResources = new Dictionary<string, int>();
            var resource = Console.ReadLine();

            while (resource != "stop")
            {
                var quantity = int.Parse(Console.ReadLine());

                if (!minedResources.ContainsKey(resource))
                {
                    minedResources[resource] = 0;
                }
                minedResources[resource] += quantity;


                resource = Console.ReadLine();
            }

            foreach (var item in minedResources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
