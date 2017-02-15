namespace _3.Text_filter
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] bannedWords = Console.ReadLine().Split(" ,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            string inputText = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                inputText = inputText.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(inputText);
        }
    }
}
