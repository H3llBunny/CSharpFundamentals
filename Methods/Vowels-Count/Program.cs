using System;
using System.Linq;
using System.Collections.Generic;

namespace VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine().ToLower();

            Console.WriteLine(CheckVowelsCount(sentence));
        }

        public static string CheckVowelsCount (string sentence)
        {
            int total = 0;
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < sentence.Length; i++)
            {
                if (vowels.Contains(sentence[i]))
                {
                    total++;
                }
            }

            return total.ToString();
        }
    }
}