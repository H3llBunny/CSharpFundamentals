using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace Nether_Realms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string demonsPattern = @"[\s,]+";

            string[] demons = Regex.Split(input, demonsPattern).OrderBy(x => x).ToArray();

            for (int i = 0; i < demons.Length; i++)
            {
                string namePattern = @"[^\d+\s+\-\*/\.,]";
                var nameRegex = new Regex(namePattern);
                MatchCollection nameMatches = nameRegex.Matches(demons[i]);
                int health = 0;
                double damage = 0;

                foreach (Match match in nameMatches)
                {
                    health += (int)match.Value[0];
                }

                string dmgPattern = @"(-?\+?\d+(?:\.\d+)?)";
                var dmgRegex = new Regex(dmgPattern);
                MatchCollection dmgMatches = dmgRegex.Matches(demons[i]);

                foreach (Match dmg in dmgMatches)
                {
                    damage += double.Parse(dmg.Value);
                }

                string multiPattern = @"[*\/]";
                var multiRegex = new Regex(multiPattern);
                MatchCollection multiMatches = multiRegex.Matches(demons[i]);

                foreach (Match multiMatch in multiMatches)
                {
                    if (multiMatch.Value == "*")
                    {
                        damage *= 2;
                    }
                    else if (multiMatch.Value == "/")
                    {
                        damage /= 2;
                    }
                }

                Console.WriteLine($"{demons[i]} - {health} health, {damage:f2} damage");
            }
        }
    }
}