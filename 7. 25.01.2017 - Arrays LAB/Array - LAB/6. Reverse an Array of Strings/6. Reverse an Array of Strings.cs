namespace _6.Reverse_an_Array_of_Strings
{
    using System;

    /// Program to read an array of strings, reverse it 
    /// and print its elements. 
    public class Program
    {
        public static void Main()
        {
            string[] stringArray = Console.ReadLine().Trim()
                                .Split(' ');
            Array.Reverse(stringArray);
            Console.WriteLine(string.Join(" ", stringArray)); 
        }
    }
}
