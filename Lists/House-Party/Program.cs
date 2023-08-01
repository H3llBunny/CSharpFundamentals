using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commandCount = int.Parse(Console.ReadLine());
            string command = string.Empty;
            List<string> guestList = new List<string>();

            for (int i = 0; i < commandCount; i++)
            {
                command = Console.ReadLine();

                if (command.Split()[2].Contains("going!"))
                {
                    string name = command.Split()[0].ToString();

                    if (guestList.Contains(name))
                    {
                        Console.WriteLine(name + " is already in the list!");
                    }
                    else
                    {
                        guestList.Add(name);
                    }
                }
                else
                {
                    string name = command.Split()[0].ToString();

                    if (guestList.Contains(name) != true)
                    {
                        Console.WriteLine(name + " is not in the list!");
                    }
                    else
                    {
                        guestList.Remove(name);
                    }
                }
            }

            for (int i = 0; i < guestList.Count; i++)
            {
                Console.WriteLine(guestList[i]);
            }
        }
    }
}