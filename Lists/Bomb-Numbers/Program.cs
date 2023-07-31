using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bomb = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                int bombNumber = bomb[0];
                int bombPower = bomb[1];

                if (numbers[i] == bombNumber)
                {
                    for (int j = 1; j <= bombPower; j++)
                    {
                        if (i - j < 0)
                        {
                            break;
                        }
                        else
                        {
                            numbers[i - j] = 0;
                        }
                    }

                    for (int j = 1; j <= bombPower; j++)
                    {
                        if(i + j > numbers.Count - 1)
                        {
                            break;
                        }
                        else
                        {
                            numbers[i + j] = 0;
                        }
                    }

                    numbers[i] = 0;
                }
            }

            int sum = numbers.Sum();
            Console.WriteLine(sum);
        }
    }
}