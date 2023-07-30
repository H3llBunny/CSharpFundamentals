using System;

namespace SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int num = 1; num <= n; num++)
            {
                int sumOfDigits = 0;
                int digits = num;
                while (digits > 0)
                {
                    sumOfDigits += digits % 10;
                    digits = digits / 10;
                    if (num == n && digits == 0)
                    {
                        Console.WriteLine(sumOfDigits);
                    }
                }
            }
        }
    }
}