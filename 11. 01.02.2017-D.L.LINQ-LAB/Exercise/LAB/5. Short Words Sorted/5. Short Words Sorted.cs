namespace _5.Short_Words_Sorted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// Read a text, extract its words, find 
    /// all short words (less than 5 characters)
    /// and print them alphabetically, in lowercase.
    public class Program
    {
        public static void Main()
        {
            char[] separators
                = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };

            List<string> result = Console.ReadLine().ToLower()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .Where(n => n.Length < 5)
                .OrderBy(n => n)
                .ToList();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
