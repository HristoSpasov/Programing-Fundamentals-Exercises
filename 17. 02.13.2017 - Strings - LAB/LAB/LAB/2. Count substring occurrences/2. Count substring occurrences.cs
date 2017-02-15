namespace _2.Count_substring_occurrences
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string inputText = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();

            int patternCount = 0;
            int currIndex = inputText.IndexOf(pattern);

            while (currIndex > -1)
            {
                patternCount++;
                currIndex = inputText.IndexOf(pattern, currIndex + 1);
            }

            Console.WriteLine(patternCount);
        }
    }
}
