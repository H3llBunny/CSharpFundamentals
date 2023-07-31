using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            double totalSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string tmpStr = input[i];
                var tmpList = new List<string>();
                int frontIndex = 0;
                int backIndex = 0;
                bool check = false;
                double sum = 0;

                foreach (var c in tmpStr)
                {
                    if (char.IsLetter(c))
                    {
                        if (!check)
                        {
                            frontIndex = (int)c % 32;
                            tmpList.Add(c.ToString());
                        }
                        else if (check)
                        {
                            backIndex = (int)c % 32;
                            tmpList.Add(c.ToString());
                        }
                    }
                    else if (char.IsDigit(c) && !check)
                    {
                        tmpList.Add(c.ToString());
                        check = true;
                    }
                    else if (char.IsDigit(c) && check)
                    {
                        tmpList[1] += c.ToString();
                    }
                }

                if (char.IsUpper(tmpList[0].Substring(0, 1)[0]))
                {
                    double number = double.Parse(tmpList[1]);
                    sum = number / frontIndex;
                }
                else
                {
                    double number = double.Parse(tmpList[1]);
                    sum = number * frontIndex;
                }

                if (char.IsUpper(tmpList[2].Substring(0, 1)[0]))
                {
                    sum -= backIndex;
                }
                else
                {
                    sum += backIndex;
                }

                totalSum += sum;
            }

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
