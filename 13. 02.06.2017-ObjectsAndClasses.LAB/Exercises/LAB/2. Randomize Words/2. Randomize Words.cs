namespace _2.Randomize_Words
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// Randomize words
    public class Program
    {
        public static void Main()
        {
            string[] words = Console.ReadLine()
                .Split();

            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                string currWord = words[i];
                int currRandomId = random.Next(0, words.Length);
                string tmpWord = words[currRandomId];
                words[i] = tmpWord;
                words[currRandomId] = currWord;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
