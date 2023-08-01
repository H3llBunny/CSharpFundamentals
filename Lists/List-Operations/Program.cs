using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                if (command.Contains("Add"))
                {
                    int number = int.Parse(command.Split()[1]);
                    list.Add(number);
                }
                else if (command.Contains("Insert"))
                {
                    int index = int.Parse(command.Split()[2]);
                    int number = int.Parse(command.Split()[1]);

                    if (index >= 0 && index < list.Count)
                    {
                        list.Insert(index, number);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command.Contains("Remove"))
                {
                    int index = int.Parse(command.Split()[1]);

                    if (index >= 0 && index < list.Count)
                    {
                        list.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command.Contains("Shift left"))
                {
                    int count = int.Parse(command.Split()[2]);

                    for (int i = 0; i < count; i++)
                    {
                        int firstElement = list[0];

                        for (int j = 0; j < list.Count - 1; j++)
                        {
                            list[j] = list[j + 1];
                        }

                        list[list.Count - 1] = firstElement;
                    }
                }
                else if (command.Contains("Shift right"))
                {
                    int count = int.Parse(command.Split()[2]);

                    for (int i = 0; i < count; i++)
                    {
                        int lastElement = list[list.Count - 1];

                        for (int j = list.Count - 1; j > 0; j--)
                        {
                            list[j] = list[j - 1];
                        }

                        list[0] = lastElement;
                    }
                }
            }

            Console.WriteLine(string.Join(' ', list));
        }
    }
}
