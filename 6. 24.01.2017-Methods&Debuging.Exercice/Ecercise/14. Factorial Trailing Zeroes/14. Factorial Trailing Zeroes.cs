namespace _14.Factorial
{
    using System;
    using System.Numerics;

    /// Calculate and print  factorial trailing zeros
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            FactorialCalculate(n);
        }

        public static void FactorialCalculate(int n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

        int zerosCount = 0;
            do
            {
                if (factorial % 10 == 0)
                {
                    zerosCount++;
                    factorial /= 10;
                }
            } while (factorial % 10 == 0);
        
            Console.WriteLine(zerosCount);
        }
    }
}
