namespace _6.Prime_Checker
{
    using System;

    /// Check if input integer is prime
    public class Program
    {
        public static void Main(string[] args)
        {
            long inputNumber = long.Parse(Console.ReadLine());
            IsPrimeCheck(inputNumber);

            if (inputNumber == 0 || inputNumber == 1)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine(IsPrimeCheck(inputNumber));
            }    
        }

        public static bool IsPrimeCheck(long inputNumber)
        {
            bool isPrime = true;
            for (long i = 2; i <= (long)Math.Sqrt(inputNumber); i++)
            {
                if (inputNumber % i == 0)
                {
                    isPrime = false;
                    return isPrime;
                }    
            }

            return isPrime;
        }
    }
}
