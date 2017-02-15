namespace _4.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public  class Program
    {
        public static void Main()
        {
            string[] inputText = Console.ReadLine().Split(" ,.?!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            List<string> palindromeWords = new List<string>();

            foreach (var word in inputText)
            {
                string wordReverse = new string(word.ToCharArray().Reverse().ToArray());

                if (string.Compare(word, wordReverse, false) == 0)
                {
                    palindromeWords.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", palindromeWords.Distinct().OrderBy(x => x)));
        }
    }
}
