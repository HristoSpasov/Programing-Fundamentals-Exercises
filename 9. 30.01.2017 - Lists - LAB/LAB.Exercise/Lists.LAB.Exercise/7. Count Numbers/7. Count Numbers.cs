namespace _7.Count_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// Read a list of integers in range [0…1000] and 
    /// print them in ascending order along with their 
    /// number of occurrences.
    public class Program
    {
        public static void Main()
        {
            /// Read input numbers and parse 'em in an integer list
            List<int> numList = Console.ReadLine()
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse).ToList();
            
            /// Addind data type max value to count the last number in the list
            numList.Add(int.MaxValue);

            /// Sort the list and loop over to count and fill data in two new lists:
            ///  - first list to preserve number value
            ///  - second list to preserve the number of occurrences of the number
            numList.Sort();
            List<int> resultNumList = new List<int>();
            List<int> resultNumCountList = new List<int>();

            int currentNum = 0;
            int currentNumCount = 1;
            for (int i = 0; i < numList.Count - 1; i++)
            {
                currentNum = numList[i];
                if (numList[i] == numList[i + 1])
                {
                    currentNumCount++;
                }
                else
                {
                    resultNumList.Add(currentNum);
                    resultNumCountList.Add(currentNumCount);
                    currentNumCount = 1;
                }
            }

            /// Loop over to print each number and its occurences in the list.
            for (int i = 0; i < resultNumList.Count; i++)
            {
                Console.WriteLine($"{resultNumList[i]} -> {resultNumCountList[i]}");
            }
        }
    }
}
