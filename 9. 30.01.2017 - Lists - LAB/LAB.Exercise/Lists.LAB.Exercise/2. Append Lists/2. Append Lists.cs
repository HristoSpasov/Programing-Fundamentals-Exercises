namespace _2.Append_Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// Program to append several lists of numbers.
    public class Program
    {
        public static void Main()
        {
            char[] separator = new char[] { ' ' };
            List<string> stringTokens = Console.ReadLine()
                            .Trim().Split('|')
                            .ToList();
            stringTokens.Reverse();
            List<string> resultStringList = new List<string>();
            
            for (int i = 0; i < stringTokens.Count; i++)
            {
                resultStringList.AddRange(stringTokens[i].Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList());
            }

            Console.WriteLine(string.Join(" ", resultStringList));
        }
    }
}

// for (int i = 0; i < stringTokens.Count; i++)
// {
//     stringTokens[i] = stringTokens[i].Replace(" ", string.Empty);
// }
