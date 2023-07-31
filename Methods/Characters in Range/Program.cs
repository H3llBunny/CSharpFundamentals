using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            PrintBetweenChars(firstChar, secondChar);
        }

        private static void PrintBetweenChars(char firstChar, char secondChar)
        {
            int CharStart = Math.Min(firstChar, secondChar);
            int CharEnd = Math.Max(firstChar, secondChar);

            for (int i = CharStart + 1; i < CharEnd; i++)
            {
                Console.Write((char)i + " ");
            }

            Console.WriteLine();
        }
    }
}