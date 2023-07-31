using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> arr = Console.ReadLine().Split('|').Reverse().ToList();
            List<int> numbers = new List<int>();

            foreach (var str in arr)
            {
                numbers.AddRange(str.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}