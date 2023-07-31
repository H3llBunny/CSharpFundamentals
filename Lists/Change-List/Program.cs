using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                if (command.Contains("Delete"))
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        int numberToRemove = int.Parse(command.Split()[1]);
                        if (list[i] == numberToRemove)
                        {
                            list.Remove(list[i]);
                        }
                    }
                }
                else if (command.Contains("Insert"))
                {
                    int numberToAdd = int.Parse(command.Split()[1]);
                    int position = int.Parse(command.Split()[2]);
                    list.Insert(position, numberToAdd);
                }
            }

            Console.WriteLine(string.Join(' ', list));
        }
    }   
}