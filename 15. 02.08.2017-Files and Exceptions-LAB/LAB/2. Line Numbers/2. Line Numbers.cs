namespace _2.Line_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// Program that reads a text file and inserts line
    /// numbers in front of each of its lines. The 
    /// result is written to another text file. 
    public class Program
    {
        public static void Main()
        {
            string[] lines = File.ReadAllLines("./Input.txt");

            List<string> outputLines = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                outputLines.Add($"{i + 1}. {lines[i]}");
            }

            File.WriteAllLines("./Output.txt", outputLines);
        }
    }
}
