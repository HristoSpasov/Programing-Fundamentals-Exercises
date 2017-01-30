namespace _2.Sign_of_Integer_Number
{
    using System;

    /// Prints sign of integer
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }

        public static void PrintSign(int n)
        {
            if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {n} is zero.");
            }
        }
    }
}
