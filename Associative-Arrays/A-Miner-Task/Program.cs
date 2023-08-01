using System;
using System.Collections.Generic;
using System.Linq;

namespace AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            string input;
            int counter = 0;

            while ((input = Console.ReadLine()) != "stop")
            {

                if (resources.ContainsKey(input))
                {
                    resources[input] += int.Parse(Console.ReadLine());
                }
                else
                {
                    resources.Add(input, int.Parse(Console.ReadLine()));
                }
            }

            foreach (var resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}

