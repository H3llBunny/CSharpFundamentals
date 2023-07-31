using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] numbers = Console.ReadLine().TrimStart('0').ToCharArray();
            int n = int.Parse(Console.ReadLine());
            
            if (n == 0)
            {
                Console.WriteLine("0");

                return;
            }
            var newNum = new List<string>();

            int parse = 0;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                parse = (int.Parse(Convert.ToString(numbers[i])) * n) + parse;
                newNum.Insert(0, (parse % 10).ToString());
                parse /= 10;
            }

            if(parse > 0)
            {
                Console.WriteLine($"{parse}{string.Join("", newNum)}");
            }
            else
            {
                Console.WriteLine($"{string.Join("", newNum)}");
            }
        }
    }
}