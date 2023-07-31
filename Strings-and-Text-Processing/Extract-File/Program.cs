using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] filePath = Console.ReadLine().Split(@"\");
            string[] spliter = filePath[filePath.Length - 1].Split(".");

            string fileName = spliter[0];
            string extension = spliter[1];

            Console.WriteLine("File name: {0}", fileName);
            Console.WriteLine("File extension: {0}", extension);
        }
    }
}