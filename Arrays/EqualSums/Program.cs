using System;
using System.Linq;
namespace EqualSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isTrue = false;

            for (int i = 0; i < arr.Length; i++)
            {
                int leftSum = 0;

                for (int k = 0; k < i; k++)
                {
                    leftSum += arr[k];
                }

                int rightSum = 0;

                for (int j = arr.Length - 1; j > i; j--)
                {
                    rightSum += arr[j];
                }

                if (leftSum == rightSum && !isTrue)
                {
                    Console.WriteLine(i);
                    isTrue = true;
                }
            }

            if (!isTrue)
            {
                Console.WriteLine("no");
            }
        }
    }
}