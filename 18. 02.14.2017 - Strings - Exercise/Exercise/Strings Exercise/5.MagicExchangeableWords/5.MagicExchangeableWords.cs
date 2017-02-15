namespace _5.MagicExchangeableWords
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();

            char[] firstWord = input[0].Distinct().ToArray();
            char[] secondWord = input[1].Distinct().ToArray();

            bool isExchangable = default(bool);

            if (firstWord.Length == secondWord.Length)
            {
                isExchangable = true;
            }

            Console.WriteLine(isExchangable ? "true" : "false");
        }
    }
}