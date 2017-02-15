namespace _4.Character_Multiplier
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();

            char[] firstWord = input[0].ToCharArray();
            char[] secondWord = input[1].ToCharArray();

            long sumChars = 0;

            if (firstWord.Length == secondWord.Length)
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                    sumChars += (int)firstWord[i] * (int)secondWord[i];
                }
            }
            else if (firstWord.Length > secondWord.Length)
            {
                for (int i = 0; i < secondWord.Length; i++)
                {
                    sumChars += (int)firstWord[i] * (int)secondWord[i];
                }

                for (int i = secondWord.Length; i < firstWord.Length; i++)
                {
                    sumChars += (int)firstWord[i];
                }
            }
            else
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                    sumChars += (int)firstWord[i] * (int)secondWord[i];
                }

                for (int i = firstWord.Length; i < secondWord.Length; i++)
                {
                    sumChars += (int)secondWord[i];
                }
            }

            Console.WriteLine(sumChars);
        }
    }
}
