namespace StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, originalNumber, sumOfFactorials = 0, digit;
            int factorial;

            n = Convert.ToInt32(Console.ReadLine());
            originalNumber = n;

            while (n > 0)
            {
                digit = n % 10; //getting the last number
                factorial = CalculateFactorial(digit);
                sumOfFactorials += factorial;
                n /= 10; //removing the last number
            }

            if (sumOfFactorials == originalNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }

        static int CalculateFactorial(int num)
        {
            int result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}