namespace _3.Unicode_Characters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            char[] inputString = Console.ReadLine().ToCharArray();

            List<string> unicode = new List<string>();

            foreach (var character in inputString)
            {
                string currCharr = "\\u" + ((int)character).ToString("X4").ToLower();
                unicode.Add(currCharr);
            }

            Console.WriteLine(string.Join(string.Empty, unicode));
        }
    }
}
