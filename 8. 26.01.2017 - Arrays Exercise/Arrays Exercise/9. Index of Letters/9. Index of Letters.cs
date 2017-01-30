namespace _9.Index_of_Letters
{
    using System;
    using System.Text;

    /// Print index of every letter in given string
    /// a -> 0
    /// b -> 1
    /// c -> 2
    public class Program
    {
        public static void Main(string[] args)
        {
            char[] alphabetArray = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] inputArray = Console.ReadLine().ToCharArray();
            var result = new StringBuilder();
            for (int str = 0; str < inputArray.Length; str++)
            {
                for (int alphabet = 0; alphabet < alphabetArray.Length; alphabet++)
                {
                    if (inputArray[str] == alphabetArray[alphabet])
                    {
                        result.Append($"{inputArray[str]} -> {alphabet}" + Environment.NewLine);
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
