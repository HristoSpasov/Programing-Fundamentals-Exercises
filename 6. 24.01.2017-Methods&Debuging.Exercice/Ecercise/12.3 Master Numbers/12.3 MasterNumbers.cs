namespace _12.Master_Numbers
{
    using System;

    /// Print master number in range from [1...n]
    /// •Is symmetric (palindrome), e.g. 5, 77, 282, 14341, 9553559.
    /// •Its sum of digits is divisible by 7, e.g. 77, 313, 464, 5225, 37173.
    /// •Holds at least one even digit, e.g. 232, 707, 6886, 87578.
    public class Program
    {
        public static void Main(string[] args)
        {
            int topRangeNumber = int.Parse(Console.ReadLine()); /// Input integer

            for (int i = 1; i <= topRangeNumber; i++)
            {
                /// Methods to handle all requirements
                bool isSymetric = IsSymetric(i);
                bool isDivisibleBySeven = IsDivisibleBySeven(i);
                bool hasOneEvenDigit = HasOneEvenDigit(i);

                /// Print result
                if (IsSymetric(i) == true && IsDivisibleBySeven(i) == true && HasOneEvenDigit(i) == true)
                {
                    Console.WriteLine(i);
                }
            }
        }

        /// Check number if it is symetric
        public static bool IsSymetric(int currentNumber)
        {
            bool isSymetric = true;

            string currentNumberString = currentNumber.ToString(); /// Convert current number to string
            for (int i = 0; i < currentNumberString.Length / 2; i++)
            {
                if (currentNumberString[i] != currentNumberString[currentNumberString.Length - i - 1])
                {
                    isSymetric = false;
                    return false;
                }
            }

            /// Return result to Main()
            return isSymetric;
        }

        /// Check if sum of number digits is divisible by 7
        public static bool IsDivisibleBySeven(int currentNumber)
        {
            bool isDivisibleBySeven = false;

            /// Sum current number digits
            int sumOfDigits = 0;
            while (currentNumber > 0)
            {
                sumOfDigits += currentNumber % 10;
                currentNumber /= 10;
            }

            /// Check if the sum of the digits is divisible by 7
            if (sumOfDigits % 7 == 0)
            {
                isDivisibleBySeven = true;
            }

            /// Return result to Main()
            return isDivisibleBySeven;
        }

        /// Check if number has at least one even digit
        public static bool HasOneEvenDigit(int currentNumber)
        {
            bool hasOneEvenDigit = false;

            while (currentNumber > 0)
            {
                if (currentNumber % 10 % 2 == 0)
                {
                    return true;
                }
                else
                {
                    currentNumber /= 10;
                }
            }
            
            /// Return result to Main()
            return hasOneEvenDigit;
        }
    }
}
