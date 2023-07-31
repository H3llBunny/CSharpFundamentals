using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "3:1")
            {
                if (command.Contains("merge"))
                {
                    int startIndex = int.Parse(command.Split()[1]);
                    int endIndex = int.Parse(command.Split()[2]);

                    if(startIndex < 0)
                    {
                        startIndex = 0;
                    }

                    if(endIndex > arr.Count - 1)
                    {
                        endIndex = arr.Count - 1;
                    }

                    for (int i = startIndex + 1; i <= endIndex; i++)
                    {
                        arr[startIndex] += arr[startIndex + 1];
                        arr.RemoveAt(startIndex + 1);
                    }
                }
                else if (command.Contains("divide"))
                {
                    int index = int.Parse(command.Split()[1]);
                    int partitions = int.Parse(command.Split()[2]);
                    string partitionData = arr[index];
                    arr.RemoveAt(index);
                    int partSize = partitionData.Length / partitions;
                    int reminder = partitionData.Length % partitions;

                    List<string> tmpData = new List<string>();

                    for (int i = 0; i < partitions; i++)
                    {
                        string tmpString = null;

                        for (int j = 0; j < partSize; j++)
                        {
                            tmpString += partitionData[(i * partSize) + j];
                        }
                        if(i == partitions - 1 && reminder != 0)
                        {
                            tmpString += partitionData.Substring(partitionData.Length - reminder);
                        }

                        tmpData.Add(tmpString);
                    }

                    arr.InsertRange(index, tmpData);
                }
            }

            Console.WriteLine(string.Join(' ', arr));
        }
    }
}