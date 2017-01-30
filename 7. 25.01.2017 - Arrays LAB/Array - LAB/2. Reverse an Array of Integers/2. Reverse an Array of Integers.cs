namespace _2.Reverse_an_Array_of_Integers
{
    using System;

    /// Read array of inntegers and print numbers in reverse order
    public class Program
    {
        public static void Main()
        {
            int arraySize = int.Parse(Console.ReadLine());
            int[] numberArray = new int[arraySize];
            ArrayInput(arraySize, numberArray);
            int[] reverseArray = new int[arraySize];
            ReverseArray(numberArray, reverseArray);
            PrintReverseArray(reverseArray);
        }

        /// Read array elements
        public static void ArrayInput(int arraySize, int[] numberArray)
        {
            for (int i = 0; i < arraySize; i++)
            {
                numberArray[i] = int.Parse(Console.ReadLine());
            }
        }

        /// Reverse array
        public static void ReverseArray(int[] numberArray, int[] reverseAray)
        {
            for (int i = 0; i < numberArray.Length; i++)
            {
                reverseAray[i] = numberArray[numberArray.Length - i - 1];
            }
        }

        /// Print reversed array
        public static void PrintReverseArray(int[] reverseArray)
        {
            Console.WriteLine(string.Join(" ", reverseArray));
        }
    }
}
