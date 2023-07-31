using System;

namespace SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int workersCut = 26;
            int dayCut = 10;
            int totalAmount = 0;
            int days = 0;

            if (startingYield < 100)
            {
                Console.WriteLine(days);
                Console.WriteLine(totalAmount);
            }

            else
            {
                while (startingYield >= 100)
                {
                    totalAmount += startingYield - workersCut;
                    startingYield = startingYield - dayCut;
                    days++;
                }

                totalAmount = totalAmount - workersCut;
                Console.WriteLine(days);
                Console.WriteLine(totalAmount);
            }
        }
    }
}