namespace _9.Melrah_Shake
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string inputString = Console.ReadLine();
            string shakePattern = Console.ReadLine();

            while (true)
            {
                int leftIndex = inputString.IndexOf(shakePattern);
                int rightIndex = inputString.LastIndexOf(shakePattern);

                if (leftIndex != rightIndex && leftIndex != -1 && rightIndex != -1 && shakePattern.Length > 0)
                {
                    Console.WriteLine("Shaked it.");
                    inputString = inputString.Remove(leftIndex, shakePattern.Length);
                    inputString = inputString.Remove(inputString.LastIndexOf(shakePattern), shakePattern.Length);
                    shakePattern = shakePattern.Remove(shakePattern.Length / 2, 1);
                }
                else
                {
                    Console.WriteLine("No shake.");
                    break;
                }
            }

            Console.WriteLine(inputString);
        }
    }
}
