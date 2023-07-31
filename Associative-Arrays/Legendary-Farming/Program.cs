using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input;
            Dictionary<string, int> legendaryItems = new Dictionary<string, int>();
            Dictionary<string, int> junkItems = new Dictionary<string, int>();
            legendaryItems.Add("shards", 0);
            legendaryItems.Add("fragments", 0);
            legendaryItems.Add("motes", 0);
            bool checker = true;

            while (checker)
            {
                input = Console.ReadLine().Split();

                for (int i = 0; i < input.Length; i++)
                {
                    int quantity = int.Parse(input[i]);
                    i++;
                    string material = input[i].ToLower();

                    if (material == "shards")
                    {
                        legendaryItems["shards"] += quantity;

                        if (legendaryItems["shards"] >= 250)
                        {
                            string item = "Shadowmourne";
                            Console.WriteLine(item + " obtained!");
                            legendaryItems["shards"] -= 250;
                            var orderedItems = legendaryItems.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToList();

                            foreach (var currentMaterial in orderedItems)
                            {
                                Console.WriteLine($"{currentMaterial.Key}: {currentMaterial.Value}");
                            }

                            var orderedJunkItems = junkItems.OrderBy(x => x.Key);

                            foreach (var junk in orderedJunkItems)
                            {
                                Console.WriteLine($"{junk.Key}: {junk.Value}");
                            }

                            checker = false;
                            break;
                        }
                    }
                    else if (material == "fragments")
                    {
                        legendaryItems["fragments"] += quantity;

                        if (legendaryItems["fragments"] >= 250)
                        {
                            string item = "Valanyr";
                            Console.WriteLine(item + " obtained!");
                            legendaryItems["fragments"] -= 250;
                            var orderedItems = legendaryItems.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToList();

                            foreach (var currentMaterial in orderedItems)
                            {
                                Console.WriteLine($"{currentMaterial.Key}: {currentMaterial.Value}");
                            }

                            var orderedJunkItems = junkItems.OrderBy(x => x.Key);

                            foreach (var junk in orderedJunkItems)
                            {
                                Console.WriteLine($"{junk.Key}: {junk.Value}");
                            }

                            checker = false;
                            break;
                        }
                    }
                    else if (material == "motes")
                    {
                        legendaryItems["motes"] += quantity;

                        if (legendaryItems["motes"] >= 250)
                        {
                            string item = "Dragonwrath";
                            Console.WriteLine(item + " obtained!");
                            legendaryItems["motes"] -= 250;
                            var orderedItems = legendaryItems.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToList();

                            foreach (var currentMaterial in orderedItems)
                            {
                                Console.WriteLine($"{currentMaterial.Key}: {currentMaterial.Value}");
                            }

                            var orderedJunkItems = junkItems.OrderBy(x => x.Key);

                            foreach (var junk in orderedJunkItems)
                            {
                                Console.WriteLine($"{junk.Key}: {junk.Value}");
                            }

                            checker = false;
                            break;
                        }
                    }
                    else
                    {
                        if (junkItems.ContainsKey(material))
                        {
                            junkItems[material] += quantity;
                        }
                        else
                        {
                            junkItems.Add(material, quantity);
                        }
                    }
                }
            }
        }
    }
}