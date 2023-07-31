using System;
using System.Linq;

namespace FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal firstNum = decimal.Parse(Console.ReadLine());
            decimal secondNum = decimal.Parse(Console.ReadLine());
            decimal result = factorial(firstNum, secondNum);

            Console.WriteLine($"{result:f2}");
            
        }
        public static decimal factorial(decimal firstNum, decimal secondNum)
        {
            decimal factorial1 = firstNum;
            decimal factorial2 = secondNum;

            for (decimal i = firstNum - 1; i > 0; i--)
            {
                factorial1 *= i;
            }

            for (decimal i = factorial2 - 1; i > 0; i--)
            {
                factorial2 *= i;
            }

            return factorial1 / factorial2;
        }
    }
}