using System;

namespace PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studenCount = int.Parse(Console.ReadLine());
            double sabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());
            double sum = 0;

            if (studenCount >= 6)
            {
                double freeBelts = (studenCount / 6);
                Math.Ceiling(freeBelts);

                if (sum <= money)
                {
                    Console.WriteLine($"The money is enough - it would cost {sum:F2}lv.");
                }
                else
                {
                    Console.WriteLine($"John will need {sum - money:F2}lv more.");
                }
            }

            else if (studenCount < 6)
            {
                sum = (sabersPrice * Math.Ceiling(studenCount + (studenCount * 0.1))) + (robesPrice * studenCount) + (beltsPrice * studenCount);
                if (sum <= money)
                {
                    Console.WriteLine($"The money is enough - it would cost {sum:F2}lv.");
                }
                else
                {
                    Console.WriteLine($"John will need {sum - money:F2}lv more.");
                }
            }
        }
    }
}