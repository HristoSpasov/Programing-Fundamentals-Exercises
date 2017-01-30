namespace _1.Largest_Common_End
{
    using System;
    
    /// Read two arrays of words and find the length of the largest 
    /// common end (left or right).
    public class Program
    {
        public static void Main()
        {
            /// Read two strings from console
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();
            
            
            string[] firstArray = firstString.Split(' '); /// Convert first string to array
            string[] secondArray = secondString.Split(' '); /// Convert second string to array
            int firstArrayLenght = firstArray.Length; /// First array lenght
            int secondArrayLenght = secondArray.Length; /// Second array lenght


            int largestCommonEndCounter = 0;
            EqualWordCounter(firstArrayLenght, secondArrayLenght, firstArray, secondArray, largestCommonEndCounter);
            largestCommonEndCounter = EqualWordCounter(firstArrayLenght, secondArrayLenght, firstArray, secondArray, largestCommonEndCounter);
            Array.Reverse(firstArray);
            Array.Reverse(secondArray);
            EqualWordCounter(firstArrayLenght, secondArrayLenght, firstArray, secondArray, largestCommonEndCounter);
            largestCommonEndCounter = EqualWordCounter(firstArrayLenght, secondArrayLenght, firstArray, secondArray, largestCommonEndCounter);

            Console.WriteLine(largestCommonEndCounter); /// Print result
        }

        /// Count equal words
        public static int EqualWordCounter(int firstArrayLenght, int secondArrayLenght, string[] firstArray, string[] secondArray, int largestCommonEndCounter)
        {
            int currentCommonEndCounter = 0;
            for (int i = 0; i < Math.Min(firstArrayLenght, secondArrayLenght); i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    currentCommonEndCounter++;
                }
            }
            if (currentCommonEndCounter > largestCommonEndCounter)
            {
               largestCommonEndCounter = currentCommonEndCounter;
            }
            return largestCommonEndCounter;
        }
    }
}
