using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"%(?<name>[A-Z][a-z]+)%.*?<(?<product>\w+)>.*?\|(?<count>[0-9]+)\|(?:[A-Za-z]+)?(?<price>\d+(?:.\d+)?)\$");
            string input = string.Empty;
            double totalIncome = 0;

            while ((input = Console.ReadLine()) != "end of shift")
            {
                if (regex.IsMatch(input))
                {
                    Match match = regex.Match(input);
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    double sumPrice = double.Parse(match.Groups["count"].Value) * double.Parse(match.Groups["price"].Value);
                    totalIncome += sumPrice;

                    Console.WriteLine($"{name}: {product} - {sumPrice:f2}");
                }
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}