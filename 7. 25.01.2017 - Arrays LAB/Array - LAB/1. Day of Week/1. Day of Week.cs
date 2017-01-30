namespace _1.Day_of_Week
{
    using System;

    /// Print day of week according to input number.
    /// If no match print "Invalid day".
    public class Program
    {
        public static void Main()
        {
            string[] dayOfWeekName = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int dayNumberInput = int.Parse(Console.ReadLine());

            if (dayNumberInput >= 1 && dayNumberInput <= 7)
            {
                for (int i = 1; i <= dayOfWeekName.Length; i++)
                {
                    if (i == dayNumberInput)
                    {
                        Console.WriteLine(dayOfWeekName[i - 1]);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
