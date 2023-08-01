using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 1;
            int biggestCounter = 0;
            int number = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }

                if (counter > biggestCounter)
                {
                    biggestCounter = counter;
                    number = nums[i];
                }
            }
            for (int i = 1; i <= biggestCounter; i++)
            {
                Console.Write(number + " ");
            }
        }
    }
}