using System;
using System.Linq;
namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagonsCount = int.Parse(Console.ReadLine());
            int[] arr = new int[wagonsCount];
            var sum = 0;

            for (int i = 0; i < wagonsCount; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < wagonsCount; i++)
            {
                Console.Write(arr[i] + " ");
            }

            for (int i = 0; i < wagonsCount; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine(Environment.NewLine + (sum));
        }
    }
}