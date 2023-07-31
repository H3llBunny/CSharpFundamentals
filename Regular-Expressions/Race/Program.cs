using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var racers = new Dictionary<string, int>();
            string[] names = Console.ReadLine().Split(", ");
            var regexWord = new Regex("[A-Za-z]");
            var regexDigit = new Regex("[0-9]");

            foreach (var name in names)
            {
                racers.Add(name, 0);
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end of race")
            {
                char[] chars = input.ToCharArray();
                string currentName = string.Empty;
                int sum = 0;

                foreach (var c in chars)
                {
                    if (regexWord.IsMatch(c.ToString()))
                    {
                        currentName += c;
                    }
                    else if (regexDigit.IsMatch(c.ToString()))
                    {
                        sum += int.Parse((c).ToString());
                    }
                }

                if (racers.ContainsKey(currentName))
                {
                    racers[currentName] += sum;
                }
            }

            int counter = 0;

            foreach (var racer in racers.OrderByDescending(x => x.Value))
            {
                if (counter == 0)
                {
                    Console.WriteLine($"1st place: {racer.Key}");
                    counter++;
                }
                else if(counter == 1)
                {
                    Console.WriteLine($"2nd place: {racer.Key}");
                    counter++;
                }
                else if(counter == 2)
                {
                    Console.WriteLine($"3rd place: {racer.Key}");
                    break;
                }
            }
        }
    }
}