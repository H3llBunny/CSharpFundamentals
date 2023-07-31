using System;
namespace PrintAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = num1; i <= num2; i++)
            {
                Console.Write("{0} ", i);
                sum += i;
            }

            Console.WriteLine($"{Environment.NewLine}Sum: {sum}");
        }
    }
}