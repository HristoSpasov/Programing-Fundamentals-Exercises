namespace _2.Rotate_and_Sum
{
    using System;
    using System.Linq;

    /// 2.	Rotate and Sum
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputNumbers = Console.ReadLine().Trim();
            int numberOfRotations = int.Parse(Console.ReadLine());

            int[] numberArray = inputNumbers.Split(' ').Select(int.Parse).ToArray();
            
            int[] sumArray = new int[numberArray.Length];

            for (int i = 0; i < numberOfRotations; i++)
            {

                /// Rotate and save values in rotated array
                int tmpFirstValue = numberArray[numberArray.Length - 1];
                for (int rotate = 1; rotate <= numberArray.Length - 1; rotate++)
                {
                    numberArray[numberArray.Length - rotate] = numberArray[numberArray.Length - 1 - rotate];
                }
                numberArray[0] = tmpFirstValue;

                // /// Sum all reversed arrays
                for (int j = 0; j < sumArray.Length; j++)
                {
                    sumArray[j] += numberArray[j];
                }
            }

            ///Print sum array
            Console.WriteLine(string.Join(" ", sumArray));

        }
    }
}
