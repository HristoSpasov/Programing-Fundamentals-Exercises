namespace _13.Factorial
{
    using System;
    using System.Numerics;

    /// Calculate and print n! factorial
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

            Console.WriteLine(factorial);
        }
    }
}
