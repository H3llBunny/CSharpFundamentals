using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonDontGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pokeDistance = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int index = 0;
            int sum = 0;

            while (pokeDistance.Count != 0)
            {
                index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    sum += pokeDistance[0];

                    for (int i = 1; i < pokeDistance.Count; i++)
                    {
                        if (pokeDistance[0] >= pokeDistance[i])
                        {
                            pokeDistance[i] += pokeDistance[0];
                        }
                        else if (pokeDistance[0] < pokeDistance[i])
                        {
                            pokeDistance[i] -= pokeDistance[0];
                        }
                    }

                    pokeDistance.RemoveAt(0);
                    pokeDistance.Insert(0, pokeDistance[pokeDistance.Count - 1]);
                }
                else if (index > pokeDistance.Count - 1)
                {
                    sum += pokeDistance[pokeDistance.Count - 1];

                    for (int i = pokeDistance.Count - 2; i >= 0; i--)
                    {
                        if (pokeDistance[pokeDistance.Count - 1] >= pokeDistance[i])
                        {
                            pokeDistance[i] += pokeDistance[pokeDistance.Count - 1];
                        }
                        else if (pokeDistance[pokeDistance.Count - 1] < pokeDistance[i])
                        {
                            pokeDistance[i] -= pokeDistance[pokeDistance.Count - 1];
                        }
                    }

                    pokeDistance.RemoveAt(pokeDistance.Count - 1);
                    pokeDistance.Insert(pokeDistance.Count, pokeDistance[0]);
                }
                else
                {
                    sum += pokeDistance[index];

                    for (int i = 0; i < index; i++)
                    {
                        if (pokeDistance[index] >= pokeDistance[i])
                        {
                            pokeDistance[i] += pokeDistance[index];
                        }
                        else if (pokeDistance[index] < pokeDistance[i])
                        {
                            pokeDistance[i] -= pokeDistance[index];
                        }
                    }

                    for (int i = index + 1; i < pokeDistance.Count; i++)
                    {
                        if (pokeDistance[index] >= pokeDistance[i])
                        {
                            pokeDistance[i] += pokeDistance[index];
                        }
                        else if (pokeDistance[index] < pokeDistance[i])
                        {
                            pokeDistance[i] -= pokeDistance[index];
                        }
                    }

                    pokeDistance.RemoveAt(index);
                }
            }

            Console.WriteLine(sum);
        }
    }
}
