namespace _4.Merge_Files
{
    using System;
    using System.IO;
    using System.Linq;

    /// Program that reads the contents of two text files 
    /// and merges them together into a third one.
    public class Program
    {
        public static void Main()
        {
            string[] input1 = File.ReadAllText("./Input1.txt")
                .ToLower()
                .Split(new[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] input2 = File.ReadAllText("./Input2.txt")
                .ToLower()
                .Split(new[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] result = input1.Concat(input2).ToArray();

            File.WriteAllLines("./Output.txt", result.OrderBy(x => x));
        }
    }
}
