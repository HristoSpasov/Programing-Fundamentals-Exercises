namespace _8.Multiply_Evens_by_Odds
{
    using System;

    /// Multiply the sum of odd numbers by the sum of even numbers
    public class Program
    {
        public static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            SumOfOddNumbers(inputNumber);
            SumOfEvenNumbers(inputNumber);
            int resultNumber = SumOfEvenNumbers(inputNumber) * SumOfOddNumbers(inputNumber);
            Console.WriteLine(resultNumber);
        }

        public static int SumOfOddNumbers(int tmpNumber)
        {
            int sumOfOddNumbers = 0;

            while (tmpNumber != 0)
            {
                int currentDigit = tmpNumber % 10;
                tmpNumber = tmpNumber / 10;

                if (currentDigit % 2 != 0)
                {
                    sumOfOddNumbers += currentDigit;
                }
            }
            
            return sumOfOddNumbers;
        }

        public static int SumOfEvenNumbers(int tmpNumber)
        {
            int sumOfEvenNumbers = 0;
            while (tmpNumber != 0)
            {
                int currentDigit = tmpNumber % 10;
                tmpNumber = tmpNumber / 10;

                if (currentDigit % 2 == 0)
                {
                    sumOfEvenNumbers += currentDigit;
                }
            }
            
            return sumOfEvenNumbers;
        }
    }
}
