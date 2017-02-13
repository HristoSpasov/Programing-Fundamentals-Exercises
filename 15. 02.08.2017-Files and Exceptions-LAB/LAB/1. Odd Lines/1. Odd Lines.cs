namespace _1.Odd_Lines
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    /// Program that reads a text file and writes its 
    /// every odd line in another file. Line numbers 
    /// starts from 0.
    public class Program
    {
        public static void Main()
        {
            string[] lines = File.ReadAllLines("./Input.txt");

            List<string> oddLineStrings = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                if (i % 2 != 0)
                {
                    oddLineStrings.Add(lines[i]);
                }
            }

            File.WriteAllLines("./Output.txt", oddLineStrings);
        }
    }
}
