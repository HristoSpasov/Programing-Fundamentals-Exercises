namespace _5.Sort_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// Read a list of decimal numbers and 
    /// sort them in increasing order. 
    public class Program
    {
        public static void Main()
        {
            List<double> intList = Console.ReadLine()
                        .Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                        .Select(double.Parse)
                        .ToList();
            intList.Sort();
           
            Console.WriteLine(string.Join(" <= ", intList));    
        }
    }
}
