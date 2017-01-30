namespace _7.Sum_Arrays
{
    using System;
    using System.Linq;

    /// Reads two integer arraays and sums them
    public class Program
    {
        public static void Main()
        {
            /// Read input arrays of numbers
            int[] firstIntArray = Console.ReadLine().Trim()
                        .Split(' ').Select(int.Parse).ToArray();
            int[] secondIntArray = Console.ReadLine().Trim()
                       .Split(' ').Select(int.Parse).ToArray();

            /// Method to extend shorter array lenght to longer array lenght and sum both arrays
            SumArrays(firstIntArray, secondIntArray);
        }

        /// Extend shorter array lenght to longer array lenght and sum both arrays
        public static void SumArrays(int[] firstIntArray, int[] secondIntArray)
        {
            int[] resultArray = new int[Math.Max(firstIntArray.Length, secondIntArray.Length)]; /// Assign result array lenght to the lenght of largest array

            /// Calculates result array when first array lenght is longer
            if (firstIntArray.Length > secondIntArray.Length)
            {
                int[] secondIntArrayExtend = new int[firstIntArray.Length]; /// Creates extended array of the second array

                /// Calculate values of the extended second array
                for (int i = 0; i < secondIntArrayExtend.Length; i++)
                {
                    if (i < secondIntArray.Length)
                    {
                        secondIntArrayExtend[i] = secondIntArray[i];
                    }
                    else
                    {
                        secondIntArrayExtend[i] = secondIntArray[i % secondIntArray.Length];
                    }   
                }

                /// Sum values of first aray and second extended array
                for (int i = 0; i < resultArray.Length; i++)
                {
                    resultArray[i] = firstIntArray[i] + secondIntArrayExtend[i];
                }

                /// Print result array
                Console.WriteLine(string.Join(" ", resultArray));
            }
            else if (secondIntArray.Length > firstIntArray.Length) 
            {   
                /// Calculate result when second array is longer
                int[] firstIntArrayExtend = new int[secondIntArray.Length]; /// Assign lenght of the first extended array

                /// Calculate values of the extended first array
                for (int i = 0; i < firstIntArrayExtend.Length; i++)
                {
                    if (i < firstIntArray.Length)
                    {
                        firstIntArrayExtend[i] = firstIntArray[i];
                    }
                    else
                    {
                        firstIntArrayExtend[i] = firstIntArray[i % firstIntArray.Length];
                    }
                }

                /// Sum values of first array extended array and second array
                for (int i = 0; i < resultArray.Length; i++)
                {
                    resultArray[i] = firstIntArrayExtend[i] + secondIntArray[i];
                }

                /// Print result array
                Console.WriteLine(string.Join(" ", resultArray));
            }
            else
            {   
                /// Calculate result array when both arrays have equal lenght
                for (int i = 0; i < resultArray.Length; i++)
                {
                    resultArray[i] = firstIntArray[i] + secondIntArray[i];
                }

                Console.WriteLine(string.Join(" ", resultArray));
            }
        }
    }
}
