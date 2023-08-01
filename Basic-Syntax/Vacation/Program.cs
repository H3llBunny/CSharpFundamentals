using System;
namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string group = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double price = peopleCount;

            switch (group)
            {
                case "students":
                    if (day == "friday")
                    {
                        price *= 8.45;
                    }
                    else if (day == "saturday")
                    {
                        price *= 9.80;
                    }
                    else if (day == "sunday")
                    {
                        price *= 10.46;
                    }
                    if (peopleCount >= 30)
                    {
                        price *= 0.85;
                    }
                    break;

                case "business":
                    if (peopleCount >= 100)
                    {
                        price -= 10;
                    }
                    if (day == "friday")
                    {
                        price *= 10.90;
                    }
                    else if (day == "saturday")
                    {
                        price *= 15.60;
                    }
                    else if (day == "sunday")
                    {
                        price *= 16;
                    }
                    break;

                case "regular":
                    if (day == "friday")
                    {
                        price *= 15;
                    }
                    else if (day == "saturday")
                    {
                        price *= 20;
                    }
                    else if (day == "sunday")
                    {
                        price *= 22.50;
                    }
                    if (peopleCount >= 10 && peopleCount <= 20)
                    {
                        price *= 0.95;
                    }
                    break;
            }

            Console.WriteLine("Total price: {0:F2}", price);
        }
    }
}