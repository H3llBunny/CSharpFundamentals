using System;
using System.Collections.Generic;
using System.Linq;

namespace StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine().ToList();
            int power = 0;

            for (int i = 0; i < str.Count - 1; i++)
            {
                if (str[i] == (char)'>')
                {
                    power += int.Parse((str[i + 1].ToString()));

                    for (int j = power; j > 0; j--)
                    {
                        if(i < str.Count - 1)
                        {
                            if (str[i + 1] != (char)'>')
                            {
                                str.RemoveAt(i + 1);
                                power--;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }

            Console.WriteLine(string.Join("", str));
        }
    }
}