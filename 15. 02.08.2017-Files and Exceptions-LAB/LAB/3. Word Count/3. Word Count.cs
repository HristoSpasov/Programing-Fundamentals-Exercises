namespace _3.Word_Count
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    /// Program that reads a list of words from the file
    /// words.txt and finds how many times each of the 
    /// words is contained in another file text.txt. 
    /// Matching should be case-insensitive.
    public class Program
    {
        public static string[] Fila { get; private set; }

        public static void Main()
        {
            /// Dictionary to store word count
            Dictionary<string, int> result = new Dictionary<string, int>();

            /// Read input data
            string[] wordsToCount = File.ReadAllText("./Words.txt")
                .ToLower()
                .Split(new[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .ToArray();

            string[] inputText = File.ReadAllText("./Input.txt")
                .ToLower()
                .Split(new[] { '\r', '\n', ' ', '.', '-', '!', '?', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            /// Loop over the arrays to count words
            for (int i = 0; i < wordsToCount.Length; i++)
            {
                if (!result.ContainsKey(wordsToCount[i]))
                {
                    result[wordsToCount[i]] = 0;
                }

                for (int j = 0; j < inputText.Length; j++)
                {
                    if (inputText[j] == wordsToCount[i])
                    {
                        result[wordsToCount[i]]++;
                    }
                }
            }

            /// If output file exists deletes the file
            if (File.Exists("./Output.txt"))
            {
                File.Delete("./Output.txt");
            }

            /// Print result in file
            File.AppendAllLines("./Output.txt", result
                                 .OrderByDescending(x => x.Value)
                                 .Select(w => $"{w.Key} - {w.Value}"));
        }
    }
}
