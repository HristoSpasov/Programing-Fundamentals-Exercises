namespace _4.Split_by_Word_Casing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// Read a text, split it into words and distribute them 
    /// into 3 lists:
    /// * Lower-case words 
    /// * Upper-case words
    /// * Mixed-case words 
    public class Program
    {
        public static void Main()
        {
            char[] separators = new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };

            List<string> inputList = Console.ReadLine()
                            .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                            .ToList();

            List<string> lowerCaseList = new List<string>();
            List<string> upperCaseList = new List<string>();
            List<string> mixedCaseList = new List<string>();

            for (int i = 0; i < inputList.Count; i++)
            {
                string currentString = inputList[i];
                bool isLowerCase = true;
                bool isUpperCase = true;
                for (int j = 0; j < currentString.Length; j++)
                {
                    if (currentString[j] >= 'a' && currentString[j] <= 'z')
                    {
                        isUpperCase = false;
                    }
                    else if (currentString[j] >= 'A' && currentString[j] <= 'Z')
                    {
                        isLowerCase = false;
                    }
                    else
                    {
                        isUpperCase = false;
                        isLowerCase = false;
                    }
                }

                if (isLowerCase == true && isUpperCase == false)
                {
                    lowerCaseList.Add(currentString);
                }
                else if (isLowerCase == false && isUpperCase == true)
                {
                    upperCaseList.Add(currentString);
                }
                else
                {
                    mixedCaseList.Add(currentString);
                }
            }

            /// Print result
            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCaseList));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCaseList));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCaseList));
        }
    }
}
