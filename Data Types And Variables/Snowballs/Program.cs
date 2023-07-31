using System;
using System.Numerics;

namespace Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int snowballs = int.Parse(Console.ReadLine());
            int maxSnowballSnow = 0;
            int maxSnowballTime = 0;
            int maxSnowballQuality = 0;
            BigInteger maxSnowballValue = 0;

            for (int i = 0; i < snowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue > maxSnowballValue)
                {
                    maxSnowballSnow = snowballSnow;
                    maxSnowballTime = snowballTime;
                    maxSnowballQuality = snowballQuality;
                    maxSnowballValue = snowballValue;
                }
            }

            Console.WriteLine($"{maxSnowballSnow} : {maxSnowballTime} = {maxSnowballValue} ({maxSnowballQuality})");
        }
    }
}