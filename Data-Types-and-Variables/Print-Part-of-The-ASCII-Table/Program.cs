using System;

namespace PrintPartOfTheASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte start = byte.Parse(Console.ReadLine());
            byte end = byte.Parse(Console.ReadLine());
            int asciiValue = 0;

            for (asciiValue = start; asciiValue <= end; asciiValue++)
            {
                Console.Write(" " + Convert.ToChar(asciiValue));
            }
        }
    }
}