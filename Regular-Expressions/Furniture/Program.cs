using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+(.\d+)?)!(?<quant>\d+)";
            var regex = new Regex(pattern);
            string input = string.Empty;
            var furniture = new List<string>();
            double sum = 0;

            while ((input = Console.ReadLine()) != "Purchase")
            {
                if (regex.IsMatch(input))
                {
                    Match match = regex.Match(input);
                    furniture.Add(match.Groups["name"].Value);
                    sum += double.Parse(match.Groups["price"].Value) * double.Parse(match.Groups["quant"].Value);
                }
            }

            Console.WriteLine("Bought furniture:");

            foreach (var item in furniture)
            {
                Console.WriteLine(item);
            }
            //if (furniture.Count > 0)
            //{
            //    Console.WriteLine($"{string.Join(Environment.NewLine, furniture)}");
            //}

            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}