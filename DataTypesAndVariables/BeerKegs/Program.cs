using System;

namespace BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numebrOfKegs = int.Parse(Console.ReadLine());
            double biggestKeg = 0;
            string kegName = string.Empty;

            for (int i = 0; i < numebrOfKegs; i++)
            {
                string modelOfKeg = Console.ReadLine();
                double radiusOfKeg = double.Parse(Console.ReadLine());
                double heightOfKeg = double.Parse(Console.ReadLine());
                double volume = Math.PI * radiusOfKeg * radiusOfKeg * heightOfKeg;

                if (volume > biggestKeg)
                {
                    biggestKeg = volume;
                    kegName = modelOfKeg;
                }
            }

            Console.WriteLine(kegName);
        }
    }
}