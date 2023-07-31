using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var regex = new Regex(@"@(?<planet>[A-Z][a-z]+)[^@\-!:>]*?:(?<population>[0-9]+)[^@\-!:>]*?!(?<type>[A-Z])![^@\-!:>]*?->(?<soldiers>[0-9]+)");
            var attackedPlanets = new List<string>();
            var destroyedPlanets = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string keyChars = @"[SsTtAaRr]";
                var tmpRegex = new Regex(keyChars);
                MatchCollection matches = tmpRegex.Matches(input);
                int key = matches.Count;
                string decryptedInput = string.Empty;

                foreach (var c in input)
                {
                    decryptedInput += (char)(c - key);
                }

                if (regex.IsMatch(decryptedInput))
                {
                    var match = regex.Match(decryptedInput);
                    string planet = match.Groups["planet"].Value;
                    string type = match.Groups["type"].Value;
                    switch (type)
                    {
                        case "A":
                            attackedPlanets.Add(planet);
                            break;

                        case "D":
                            destroyedPlanets.Add(planet);
                            break;

                        default:
                            break;
                    }
                }
            }

            Console.WriteLine("Attacked planets: {0}", attackedPlanets.Count);

            foreach (var planet in attackedPlanets.OrderBy(x => x))
            {
                Console.WriteLine("-> {0}", planet);
            }

            Console.WriteLine("Destroyed planets: {0}", destroyedPlanets.Count);

            foreach (var planet in destroyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine("-> {0}", planet);
            }
        }
    }
}