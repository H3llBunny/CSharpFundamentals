using System;
using System.Collections.Generic;
using System.Linq;

namespace CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var chars = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (!chars.ContainsKey(c))
                {
                    chars.Add(c, 1);
                }
                else
                {
                    chars[c]++;
                }
            }

            foreach (var character in chars)
            {
                if (character.Key != (' '))
                {
                    Console.WriteLine($"{character.Key} -> {character.Value}");
                }
            }
        }
    }
}