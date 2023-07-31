using System;
using System.Linq;

namespace NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Matrix(n);
        }
        public static void Matrix(int n)
        {
            int[] matrix = new int[n];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = n;
            }
             
            for (int i = 1; i <= n; i++)
                {

                foreach (int numbers in matrix)
                {
                    Console.Write(numbers + " ");
                }

                Console.WriteLine();
            }
        }
    }
}