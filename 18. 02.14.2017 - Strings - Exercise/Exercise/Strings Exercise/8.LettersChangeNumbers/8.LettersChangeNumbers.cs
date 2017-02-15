namespace _8.LettersChangeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] inputTokens = Console.ReadLine()
                .Trim()
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            decimal totalSum = 0.0M;

            foreach (var token in inputTokens)
            {
                char firstLetter = char.Parse(token[0].ToString());
                char secondLetter = char.Parse(token[token.Length - 1].ToString());
                decimal number = decimal.Parse(token.Substring(1, token.Length - 1 - 1));

                totalSum += MakeNumberManipulations(firstLetter, secondLetter, number);
            }

            Console.WriteLine($"{totalSum:F2}");
        }

        private static decimal MakeNumberManipulations(char firstLetter, char secondLetter, decimal number)
        {
            decimal currSum = number;
            
            if (firstLetter >= 'A' && firstLetter <= 'Z')
            {
                int firstLetterPosition = firstLetter - 'A' + 1;
                currSum /=  (decimal)firstLetterPosition;
            }
            else
            {
                int firstLetterPosition = firstLetter - 'a' + 1;
                currSum *= (decimal)firstLetterPosition;
            }

            if (secondLetter >= 'a' && secondLetter <= 'z')
            {
                int secondLetterPosition = secondLetter - 'a' + 1;
                currSum += (decimal)secondLetterPosition;
            }
            else
            {
                int secondLetterPosition = secondLetter - 'A' + 1;
                currSum -= (decimal)secondLetterPosition;
            }

            return currSum;
        }
    }
}
