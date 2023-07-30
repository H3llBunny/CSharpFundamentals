using System;

namespace PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int pokeDistance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int restPower = pokePower;
            int targetCount = 0;

            while (restPower >= pokeDistance)
            {
                restPower -= pokeDistance;
                targetCount++;

                if (restPower == pokePower * 0.5 && exhaustionFactor != 0)
                {
                    restPower /= exhaustionFactor;
                }
            }

            Console.WriteLine(restPower);
            Console.WriteLine(targetCount);
        }
    }
}