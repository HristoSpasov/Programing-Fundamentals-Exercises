namespace _1.Reverse_string
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(new string(Console.ReadLine().ToCharArray().Reverse().ToArray()));
        }
    }
}
