using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, List<string>> forceSides = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                if (input.Contains("|"))
                {
                    string[] command = input.Split(" | ");
                    string forceSide = command[0];
                    string forceUser = command[1];

                    bool userCheck = forceSides.Any(x => x.Value.Contains(forceUser));
                    bool sideCheck = forceSides.Any(x => x.Key == forceSide);

                    if (!userCheck && !sideCheck)
                    {
                        forceSides.Add(forceSide, new List<string>() { forceUser });
                    }
                    else if (!userCheck && sideCheck)
                    {
                        forceSides[forceSide].Add(forceUser);
                    }
                }
                else if (input.Contains("->"))
                {
                    string[] command = input.Split(" -> ");
                    string forceUser = command[0];
                    string forceSide = command[1];
                    bool userCheck = forceSides.Any(x => x.Value.Contains(forceUser));
                    bool sideCheck = forceSides.Any(x => x.Key == forceSide);

                    if (userCheck && sideCheck && !forceSides[forceSide].Contains(forceUser))
                    {
                        foreach (var user in forceSides.Where(x => x.Value.Contains(forceUser)))
                        {
                            user.Value.Remove(forceUser);
                        }

                        forceSides[forceSide].Add(forceUser);

                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                    else if (!userCheck && sideCheck)
                    {
                        forceSides[forceSide].Add(forceUser);

                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                    else if (!userCheck && !sideCheck)
                    {
                        forceSides.Add(forceSide, new List<string> { forceUser });

                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                    else if (userCheck && !sideCheck)
                    {
                        foreach (var user in forceSides.Where(x => x.Value.Contains(forceUser)))
                        {
                            user.Value.Remove(forceUser);
                        }

                        forceSides.Add(forceSide, new List<string> { forceUser });

                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                }
            }

            foreach (var forceSide in forceSides.Where(x => x.Value.Count > 0).OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"Side: {forceSide.Key}, Members: {forceSide.Value.Count}");

                foreach (var forceUser in forceSide.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {forceUser}");
                }
            }
        }
    }
}
