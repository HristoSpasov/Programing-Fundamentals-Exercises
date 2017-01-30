namespace _1.DeclaringAndInvokingMethods
{
    using System;

    /// Print receipt
    public class Program
    {
        public static void Main(string[] args)
        {
            Header();
            Body();
            Footer();
        }

        public static void Header()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        public static void Body()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        public static void Footer()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9" + " " + "SoftUni");
        }
    }
}
