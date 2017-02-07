namespace _3.Big_Factorial
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    /// Calculate big factorial
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger factorialResult = 1;

            for (int i = 2; i <= n; i++)
            {
                factorialResult *= i;
            }

            Console.WriteLine(factorialResult);
        }
    }
}
