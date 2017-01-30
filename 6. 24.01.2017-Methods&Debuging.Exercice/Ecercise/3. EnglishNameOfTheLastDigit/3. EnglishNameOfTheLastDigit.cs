namespace _3.EnglishNameOfTheLastDigit
{
    using System;

    /// Get the string of last digit
    public class Program
    {
        public static void Main(string[] args)
        {
            long inputNumber = long.Parse(Console.ReadLine());
            long lastDigitReturn = GetLastDigitInt(inputNumber);
            string lastDigitNameResult = FindLastDigitName(lastDigitReturn);

            Console.WriteLine(lastDigitNameResult); // Print result
        }

        /// Find and return last digit integer value
        public static long GetLastDigitInt(long inputNumber)
        {
            long lastDigit = inputNumber % 10;

            return (int)Math.Abs(lastDigit);
        }

        /// Find and return last digit string value
        public static string FindLastDigitName(long lastDigit)
        {
            long lastDigitInteger = GetLastDigitInt(lastDigit);
            string lastDigitName = string.Empty;

            switch (lastDigitInteger)
            {
                case 0: lastDigitName = "zero";
                    break;
                case 1: lastDigitName = "one";
                    break;
                case 2: lastDigitName = "two";
                    break;
                case 3: lastDigitName = "three";
                    break;
                case 4: lastDigitName = "four";
                    break;
                case 5: lastDigitName = "five";
                    break;
                case 6: lastDigitName = "six";
                    break;
                case 7: lastDigitName = "seven";
                    break;
                case 8: lastDigitName = "eight";
                    break;
                case 9: lastDigitName = "nine";
                    break;
            }
            
            return lastDigitName;
        }
    }
}
