namespace _6.Fix_Emails
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<string> input = File.ReadAllLines("./Input.txt").ToList();

            input.Remove(input[input.Count - 1]);

            List<string> userName = new List<string>();
            List<string> email = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                if (i % 2 == 0)
                {
                    userName.Add(input[i]);
                }
                else
                {
                    email.Add(input[i]);
                }
            }

            Dictionary<string, string> emailsDict = new Dictionary<string, string>();

            for (int i = 0; i < userName.Count; i++)
            {
                string currUser = userName[i];
                string currEmail = email[i];

                if (!emailsDict.ContainsKey(currUser))
                {
                    emailsDict[currUser] = currEmail;
                }
            }

            var filterDict = emailsDict.Where(x => !x.Value.EndsWith(".uk", StringComparison.OrdinalIgnoreCase)
                                                && !x.Value.EndsWith(".us", StringComparison.OrdinalIgnoreCase))
                                                .ToDictionary(p => p.Key, p => p.Value);

            if (File.Exists("./Output.txt"))
            {
                File.Delete("./Output.txt");
            }

            foreach (var emailRecord in filterDict)
            {
                File.AppendAllText("./Output.txt", $"{emailRecord.Key} -> {emailRecord.Value}\r\n");
            }
        }
    }
}
