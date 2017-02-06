namespace _4.Fix_Emails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            /// Create dictionary to store person name and email
            var emailDict = new Dictionary<string, string>();

            string inputCommand = Console.ReadLine();

            /// Loop while receive stop command and fill dictionary fields
            while (inputCommand != "stop")
            {
                if (!emailDict.ContainsKey(inputCommand))
                {
                    emailDict[inputCommand] = Console.ReadLine();
                }

                inputCommand = Console.ReadLine();
            }

            /// Remove emails ending with 'uk' & 'us'
            var resultDict = emailDict.Where(x => !x.Value.EndsWith("uk",StringComparison.OrdinalIgnoreCase) && !x.Value.EndsWith("us",StringComparison.OrdinalIgnoreCase))
                                      .ToDictionary(p => p.Key, p => p.Value);

            /// Print result on console
            foreach (var record in resultDict)
            {
                Console.WriteLine($"{record.Key} -> {record.Value}");
            }
        }
    }
}
