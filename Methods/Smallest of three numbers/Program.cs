using System;

namespace SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];

            for (int i = 0; i <= 2; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(PrintSmallestNum(numbers));
        }
        public static int PrintSmallestNum(int[] numbers)
        {
            int smallestNum = Math.Min(numbers[0], numbers[1]);

            if (smallestNum < numbers[2])
            {
    
                return smallestNum;
            }
            else
            {
                smallestNum = numbers[2];

                return smallestNum;
            }
        }
    }
}