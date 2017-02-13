namespace _5.Folder_Size
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            var testDir = Directory.GetFiles("./TestFolder/");

            var totalFileSize = 0L;

            foreach (var file in testDir)
            {
                var fileInfo = new FileInfo(file);
                totalFileSize += fileInfo.Length;
            }

            File.WriteAllText("./Output.txt", (totalFileSize / 1024.0 / 1024.0).ToString());
        }
    }
}
