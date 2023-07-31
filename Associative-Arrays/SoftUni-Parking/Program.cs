using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commandCount = int.Parse(Console.ReadLine());
            var parkingLot = new Dictionary<string, string>();

            for (int i = 0; i < commandCount; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command.Contains("register"))
                {
                    string name = command[1];
                    string licensePlate = command[2];
                    bool doesUserExist = parkingLot.Any(x => x.Key == name);

                    if (doesUserExist == true)
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parkingLot[name]}");
                    }
                    else
                    {
                        parkingLot.Add(name, licensePlate);

                        Console.WriteLine($"{name} registered {licensePlate} successfully");
                    }
                }
                else if (command.Contains("unregister"))
                {
                    string name = command[1];
                    bool doesUserExist = parkingLot.Any(x => x.Key == name);

                    if (doesUserExist)
                    {
                        parkingLot.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                }
            }

            foreach (var user in parkingLot)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}