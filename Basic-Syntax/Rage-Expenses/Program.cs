using System;

namespace RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal lostGameCount = decimal.Parse(Console.ReadLine());
            decimal headsetPrtice = decimal.Parse(Console.ReadLine());
            decimal mousePrice = decimal.Parse(Console.ReadLine());
            decimal keyboardPrice = decimal.Parse(Console.ReadLine());
            decimal displayPrice = decimal.Parse(Console.ReadLine());
            decimal rageExpense = 0;

            if (lostGameCount >= 2 && lostGameCount < 3)
            {
                rageExpense = headsetPrtice = (Math.Floor(lostGameCount / 2)) * headsetPrtice;
            }

            else if (lostGameCount >= 3 && lostGameCount < 6)
            {
                rageExpense = (Math.Floor(lostGameCount / 2) * headsetPrtice) + (Math.Floor(lostGameCount / 3) * mousePrice);
            }

            else if (lostGameCount >= 6 && lostGameCount < 12)
            {
                rageExpense = (Math.Floor(lostGameCount / 2) * headsetPrtice) + (Math.Floor(lostGameCount / 3) * mousePrice) + (Math.Floor(lostGameCount / 6) * keyboardPrice);
            }

            else if (lostGameCount >= 12)
            {
                rageExpense = (Math.Floor(lostGameCount / 2) * headsetPrtice) + (Math.Floor(lostGameCount / 3) * mousePrice) + (Math.Floor(lostGameCount / 6) * keyboardPrice) + (Math.Floor(lostGameCount / 12) * displayPrice);
            }

            Console.WriteLine($"Rage expenses: {rageExpense:F2} lv.");
        }
    }
}