using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                if (command.Contains("Add"))
                {
                    int wagonWithPassangers = int.Parse(command.Split()[1]);
                    wagons.Add(wagonWithPassangers);
                }
                else
                {
                    int passangers = int.Parse(command);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passangers <= maxCapacity)
                        {
                            wagons[i] += passangers;

                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(' ', wagons));
        }
    }
}