namespace _1.MaxSequenceEqualEle
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// Read a list of integers and find the longest 
    /// sequence of equal elements. If several exist, 
    /// print the leftmost.
    public class Program
    {
        public static void Main(string[] args)
        {
            /// Read input numbers from console and save 'em in a list
            List<int> numList = Console.ReadLine()
                                .Trim().Split(' ')
                                .Select(int.Parse)
                                .ToList();
           
            int currentSequence = 1;
            int currentStartIndex = 0;
            int bestSequence = 1;
            int bestStartIndex = 0;

            /// Loop over the list to check for longest sequence
            for (int i = 0; i < numList.Count - 1; i++)
            {
                if (numList[i + 1] == numList[i])
                {
                    currentSequence++;
                    if (currentSequence > bestSequence)
                    {
                        bestSequence = currentSequence;
                        bestStartIndex = currentStartIndex;
                    }
                }
                else
                {
                    currentStartIndex = i + 1;
                    currentSequence = 1;
                }
            }

            /// Make new list for result data
            List<int> resultList = new List<int>();

            /// Loop to save longest equal sequence in the result list
            for (int i = bestStartIndex; i < bestStartIndex + bestSequence; i++)
            {
                resultList.Add(numList[i]);
            }

            /// Print the ressult list
            Console.WriteLine(string.Join(" ", resultList));   
        }
    }
}
