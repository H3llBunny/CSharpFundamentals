using System;
using System.Linq;

namespace MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            MiddleChar(str);
        }

        public static void MiddleChar(string str)
        {
            if (str.Length % 2 == 0)
            {
                Console.WriteLine(str.Substring((str.Length / 2) - 1, 2));
            }
            else
            {
                Console.WriteLine(str[str.Length / 2]);
            }
        }
    }
}