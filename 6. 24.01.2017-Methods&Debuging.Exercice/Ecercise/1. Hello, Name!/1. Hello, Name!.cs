namespace _1.Hello__Name_
{
    using System;

    /// "Hello, Name" method practice.
    public class Program
    {
        public static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            PrintHellosFirstName(firstName);
        }

        public static void PrintHellosFirstName(string firstName)
        {
            Console.WriteLine($"Hello, {firstName}!");
        }
    }
}
