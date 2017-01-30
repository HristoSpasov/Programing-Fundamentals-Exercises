namespace _5.Compare_Char_Arrays
{
    using System;

    /// Compare two char arrays
    /// and print in alphabetical
    /// order
    public class Program
    {
        public static void Main(string[] args)
        {
            /// Read and format input strings
            char[] separator = new char[] {' '};
            string[] firstString = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);
            string[] secondString = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);
            char[] firstArray = string.Join("", firstString).ToCharArray();
            char[] secondArray = string.Join("", secondString).ToCharArray();

            /// Compare strings
            bool isEqual = true;
            bool firstIsLarger = false;
            bool secondIsLarger = false;
            for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    continue;
                }
                else if (firstArray[i] > secondArray[i])
                {
                    isEqual = false;
                    firstIsLarger = true;
                    secondIsLarger = false;
                }
                else
                {
                    isEqual = false;
                    firstIsLarger = false;
                    secondIsLarger = true;
                }
            }

            /// Print result
            if (isEqual == true && firstArray.Length == secondArray.Length)
            {
                Console.WriteLine(string.Join("", firstArray));
                Console.WriteLine(string.Join("", secondArray));
            }
            else if (isEqual == true && firstArray.Length > secondArray.Length)
            {
                Console.WriteLine(string.Join("", secondArray));
                Console.WriteLine(string.Join("", firstArray));
            }
            else if (isEqual == true && firstArray.Length < secondArray.Length)
            {
                Console.WriteLine(string.Join("", firstArray));
                Console.WriteLine(string.Join("", secondArray));
            }
            else if (firstIsLarger)
            {
                Console.WriteLine(string.Join("", secondArray));
                Console.WriteLine(string.Join("", firstArray));
            }
            else if (secondIsLarger)
            {
                Console.WriteLine(string.Join("", firstArray));
                Console.WriteLine(string.Join("", secondArray));
            }
        }
    }
}
