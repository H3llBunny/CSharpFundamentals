using System;
using System.Linq;
namespace AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int sum = Sum(num, num2);

            Console.WriteLine(Subtract(num3, sum));
        }

        public static int Sum(int num, int num2)
        {
            return num + num2;
        }

        public static int Subtract(int num3, int sum)
        {
            return sum - num3;
        }
    }   
}