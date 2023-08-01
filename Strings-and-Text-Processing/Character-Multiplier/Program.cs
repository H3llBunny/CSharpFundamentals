using System;
using System.Collections.Generic;
using System.Linq;

namespace CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(" ");

            Console.WriteLine(CharMultiplier(str));
        }

        public static int CharMultiplier(string[] str)
        {
            int sum = 0;

            if (str[0].Length > str[1].Length)
            {
                for (int i = 0; i < str[1].Length; i++)
                {
                    sum += str[0][i] * str[1][i];
                }

                for (int j = str[1].Length; j < str[0].Length; j++)
                {
                    sum += str[0][j];
                }
            }
            else if (str[0].Length < str[1].Length)
            {
                for (int i = 0; i < str[0].Length; i++)
                {
                    sum += str[1][i] * str[0][i];
                }

                for (int j = str[0].Length; j < str[1].Length; j++)
                {
                    sum += str[1][j];
                }
            }
            else
            {
                for (int i = 0; i < str[0].Length; i++)
                {
                    sum += str[0][i] * str[1][i];
                }
            }

            return sum;
        }
    }
}