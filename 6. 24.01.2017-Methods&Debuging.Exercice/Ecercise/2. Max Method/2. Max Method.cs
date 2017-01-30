namespace _2.Max_Method
{
    using System;

    /// Returns max number out of 3 numbers
    public class Program
    {
        public static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            CompareNumbers(firstNumber, secondNumber, thirdNumber);
            int maxNumberResult = CompareNumbers(firstNumber, secondNumber, thirdNumber);

            Console.WriteLine(maxNumberResult);
        }

        public static int CompareNumbers(int firstNumber, int secondNumber, int thirdNumber)
        {
            int maxResult = Math.Max(firstNumber, Math.Max(secondNumber, thirdNumber));
          
            return maxResult;
        }
    }
}
