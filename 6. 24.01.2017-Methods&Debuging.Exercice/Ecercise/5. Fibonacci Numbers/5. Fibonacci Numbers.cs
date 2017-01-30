namespace _5.Fibonacci_Numbers
{
    using System;

    /// Calculate n-th fibonachi number
    public class Program
    {
        public static void Main(string[] args)
        {
            int fibonachiElementToCalculate = int.Parse(Console.ReadLine());
            CalculateFibNumber(fibonachiElementToCalculate);
            int resultFibonacciNumber = CalculateFibNumber(fibonachiElementToCalculate);

            Console.WriteLine(resultFibonacciNumber);
        }

        public static int CalculateFibNumber(int elementNumber)
        {
            int firstElement = 1;
            int secondElement = 1;
            int resultNumber = 1;
            if (elementNumber >= 2)
            {
                for (int i = 0; i <= elementNumber - 2; i++)
                {
                    resultNumber = firstElement + secondElement;
                    firstElement = secondElement;
                    secondElement = resultNumber;
                }
            }

            return resultNumber;
        }
    }
}
