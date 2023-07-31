using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                if (command.Contains("exchange"))
                {
                    Exchanger(arr, command);
                }

                else if (command.Contains("max"))
                {
                    MaxEvenOddIndex(arr, command);
                }

                else if (command.Contains("min"))
                {
                    MinEvenOddIndex(arr, command);
                }

                else if (command.Contains("first"))
                {
                    FirstEvenOdd(arr, command);
                }

                else if (command.Contains("last"))
                {
                    LastEvenOdd(arr, command);
                }
            }
            Console.WriteLine($"[" + string.Join(", ", arr) + "]");
        }

        private static void Exchanger(int[] arr, string command)
        {
            int index = int.Parse(command.Split()[1]);

            if (index < 0 || index > arr.Length - 1)
            {
                Console.WriteLine("Invalid index");

                return;
            }

            for (int i = 0; i < index + 1; i++)
            {
                int temp = arr[0];

                for (int j = 0; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }

                arr[arr.Length - 1] = temp;
            }

            return;
        }

        private static void MaxEvenOddIndex(int[] arr, string command)
        {
            if (command.Contains("odd"))
            {
                int biggestOdd = int.MinValue;
                int indexPosition = -222;
                bool check = false;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        if (arr[i] >= biggestOdd)
                        {
                            biggestOdd = arr[i];
                            indexPosition = i;
                            check = true;
                        }
                    }
                }

                if (check)
                {
                    Console.WriteLine(indexPosition);

                    return;
                }

                Console.WriteLine("No matches");
            }

            if (command.Contains("even"))
            {
                int biggestEven = int.MinValue;
                int indexPosition = -222;
                bool check = false;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        if (arr[i] >= biggestEven)
                        {
                            biggestEven = arr[i];
                            indexPosition = i;
                            check = true;
                        }
                    }
                }

                if (check)
                {
                    Console.WriteLine(indexPosition);

                    return;
                }

                Console.WriteLine("No matches");
            }
        }

        private static void MinEvenOddIndex(int[] arr, string command)
        {
            if (command.Contains("odd"))
            {
                int minOdd = int.MaxValue;
                int indexPosition = -222;
                bool check = false;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        if (arr[i] <= minOdd)
                        {
                            minOdd = arr[i];
                            indexPosition = i;
                            check = true;
                        }
                    }
                }

                if (check)
                {
                    Console.WriteLine(indexPosition);

                    return;
                }
                Console.WriteLine("No matches");
            }

            if (command.Contains("even"))
            {
                int minEven = int.MaxValue;
                int indexPostion = -222;
                bool check = false;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        if (arr[i] <= minEven)
                        {
                            minEven = arr[i];
                            indexPostion = i;
                            check = true;
                        }
                    }
                }

                if (check)
                {
                    Console.WriteLine(indexPostion);

                    return;
                }

                Console.WriteLine("No matches");
            }
        }

        private static void FirstEvenOdd(int[] arr, string command)
        {
            if (command.Contains("odd"))
            {
                int counter = 0;
                int count = int.Parse(command.Split()[1]);
                string oddString = string.Empty;
                bool check = false;

                if (count > arr.Length)
                {
                    Console.WriteLine("Invalid count");

                    return;
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        oddString += arr[i] + " ";
                        check = true;
                        counter++;
                    }
                }

                if (check)
                {
                    if (counter >= count)
                    {
                        int[] oddArray = new int[count];

                        for (int i = 0; i < count; i++)
                        {
                            oddArray[i] = int.Parse(oddString.Split(" ")[i]);
                        }

                        Console.WriteLine($"[" + string.Join(", ", oddArray) + "]");

                        return;
                    }

                    else if (counter <= count)
                    {
                        int[] oddArray = new int[counter];

                        for (int i = 0; i < counter; i++)
                        {
                            oddArray[i] = int.Parse(oddString.Split(" ")[i]);
                        }

                        Console.WriteLine($"[" + string.Join(", ", oddArray) + "]");

                        return;
                    }
                }

                Console.WriteLine("[]");
            }

            if (command.Contains("even"))
            {
                int counter = 0;
                int count = int.Parse(command.Split()[1]);
                string evenString = string.Empty;
                bool check = false;

                if (count > arr.Length)
                {
                    Console.WriteLine("Invalid count");

                    return;
                }

                for (int i = 0; i < arr.Length; i++)
                {

                    if (arr[i] % 2 == 0)
                    {
                        evenString += arr[i] + " ";
                        check = true;
                        counter++;
                    }
                }

                if (check)
                {
                    if (counter >= count)
                    {
                        int[] evenArray = new int[count];

                        for (int i = 0; i < count; i++)
                        {
                            evenArray[i] = int.Parse(evenString.Split(" ")[i]);
                        }

                        Console.WriteLine($"[" + string.Join(", ", evenArray) + "]");

                        return;
                    }

                    else if (counter <= count)
                    {
                        int[] evenArray = new int[counter];

                        for (int i = 0; i < counter; i++)
                        {
                            evenArray[i] = int.Parse(evenString.Split(" ")[i]);
                        }

                        Console.WriteLine($"[" + string.Join(", ", evenArray) + "]");

                        return;
                    }
                }

                Console.WriteLine("[]");
            }
        }

        private static void LastEvenOdd(int[] arr, string command)
        {
            if (command.Contains("odd"))
            {
                int counter = 0;
                int count = int.Parse(command.Split()[1]);
                string oddString = string.Empty;
                bool check = false;

                if (count > arr.Length)
                {
                    Console.WriteLine("Invalid count");

                    return;
                }

                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (arr[i] % 2 != 0)
                    {
                        oddString += arr[i] + " ";
                        check = true;
                        counter++;
                    }
                }

                if (check)
                {
                    if (counter >= count)
                    {
                        int[] oddArray = new int[count];
                        for (int i = 0; i < count; i++)
                        {
                            oddArray[i] = int.Parse(oddString.Split(" ")[i]);
                        }

                        Console.WriteLine($"[" + string.Join(", ", oddArray.Reverse()) + "]");

                        return;
                    }

                    else if (counter <= count)
                    {
                        int[] oddArray = new int[counter];

                        for (int i = 0; i < counter; i++)
                        {
                            oddArray[i] = int.Parse(oddString.Split(" ")[i]);
                        }

                        Console.WriteLine($"[" + string.Join(", ", oddArray.Reverse()) + "]");

                        return;
                    }

                }
                Console.WriteLine("[]");
            }

            if (command.Contains("even"))
            {
                int counter = 0;
                int count = int.Parse(command.Split()[1]);
                string evenString = string.Empty;
                bool check = false;

                if (count > arr.Length)
                {
                    Console.WriteLine("Invalid count");

                    return;
                }

                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (arr[i] % 2 == 0)
                    {
                        evenString += arr[i] + " ";
                        check = true;
                        counter++;
                    }
                }

                if (check)
                {
                    if (counter >= count)
                    {
                        int[] evenArray = new int[count];

                        for (int i = 0; i < count; i++)
                        {
                            evenArray[i] = int.Parse(evenString.Split(" ")[i]);
                        }

                        Console.WriteLine($"[" + string.Join(", ", evenArray.Reverse()) + "]");

                        return;
                    }

                    else if (counter <= count)
                    {
                        int[] evenArray = new int[counter];

                        for (int i = 0; i < counter; i++)
                        {
                            evenArray[i] = int.Parse(evenString.Split(" ")[i]);
                        }

                        Console.WriteLine($"[" + string.Join(", ", evenArray.Reverse()) + "]");

                        return;
                    }
                }
                Console.WriteLine("[]");
            }
        }
    }
}