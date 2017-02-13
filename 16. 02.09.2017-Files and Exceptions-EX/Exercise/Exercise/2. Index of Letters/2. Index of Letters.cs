namespace _2.Index_of_Letters
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            char[] alphabet = File.ReadAllText("./Alphabet.txt").ToCharArray();

            string[] lines = File.ReadAllText("./Input.txt")
                .Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            if (File.Exists("./Output.txt"))
            {
                File.Delete("./Output.txt");
            }

            foreach (var line in lines)
            {
                char[] currLine = line.ToCharArray();

                for (int i = 0; i < currLine.Length; i++)
                {
                    for (int j = 0; j < alphabet.Length; j++)
                    {
                        if (currLine[i] == alphabet[j])
                        {
                            File.AppendAllText("./Output.txt", $"{currLine[i]} -> {j}\r\n");
                        }
                    }
                }
                File.AppendAllText("./Output.txt", Environment.NewLine);
            }
        }
    }
}
