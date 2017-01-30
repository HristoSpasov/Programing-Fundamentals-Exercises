namespace _03.Fold_and_Sum
{
    using System;
    using System.Linq;

    /// Read an array of 4*k integers, fold it 
    /// like shown below, and print the sum of 
    /// the upper and lower two rows 
    /// (each holding 2 * k integers
    public class Program
    {
        public static void Main()
        {
            int[] numberArray = Console.ReadLine().Trim()
                                .Split(' ').Select(int.Parse)
                                .ToArray();

            int[] firstRow = new int[numberArray.Length / 2];
            int[] secondRow = new int[numberArray.Length / 2];

            /// GetCalculate first row first part
            for (int i = 0; i < numberArray.Length / 4; i++)
            {
                firstRow[0 + i] = numberArray[numberArray.Length / 4 - 1 - i];
            }

            /// Get first row second part
            for (int i = 0; i < numberArray.Length / 4; i++)
            {
                firstRow[firstRow.Length / 2 + i] = numberArray[numberArray.Length - 1 - i];
            }

            /// Get second row
            for (int i = 0; i < numberArray.Length / 2; i++)
            {
                secondRow[0 + i] = numberArray[0 + (numberArray.Length / 4) + i];
            }

            int[] sumArray = new int[numberArray.Length / 2];

            /// Sum first row with second row
            for (int i = 0; i < sumArray.Length; i++)
            {
                sumArray[i] = firstRow[i] + secondRow[i];
            }

            /// Print result sum
            Console.WriteLine(string.Join(" ", sumArray));
        }
    }
}
