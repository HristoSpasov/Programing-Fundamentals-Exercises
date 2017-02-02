namespace _2.Odd_Occurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// Program that extracts from a given sequence 
    /// of words all elements that present in it odd 
    /// number of times (case-insensitive).
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> inputList = Console.ReadLine()
                .ToLower()
                .Trim()
                .Split(' ')
                .ToList();

            Dictionary<string, int> resultDict
                    = new Dictionary<string, int>();

            foreach (var word in inputList)
            {
                if (!resultDict.ContainsKey(word))
                {
                    resultDict[word] = 0;
                }

                resultDict[word]++;
            }

            List<string> resultList = new List<string>();

            foreach (var record in resultDict)
            {
                if (record.Value % 2 != 0)
                {
                    resultList.Add(record.Key);
                }
            }

            Console.WriteLine(string.Join(", ", resultList));
        }
    }
}
