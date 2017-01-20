using System;
using System.Numerics;
//This problem is from the Programming Fundamentals Retake Exam (11 September 2016).
class Program
{
    static void Main(string[] args)
    {
        //Assign variables for input data
        int totalPictures = int.Parse(Console.ReadLine());
        int filterTimePerPictureSeconds = int.Parse(Console.ReadLine());
        int percentOfPicturesForUpload = int.Parse(Console.ReadLine());
        int requiredTieForUploadPerPictureSeconds = int.Parse(Console.ReadLine());

        //Assign help variables and calculate total requred time in seconds
        long totalTimeSecondsToFilter = totalPictures * (long)filterTimePerPictureSeconds;
        long highQualityPictures = (long)Math.Ceiling(totalPictures * percentOfPicturesForUpload / 100.00);
        long totalTimeForUpload = (long)highQualityPictures * requiredTieForUploadPerPictureSeconds;
        
        long totalRequredTimeSeconds = (long)(totalTimeSecondsToFilter + totalTimeForUpload);
        
        TimeSpan totalTime = TimeSpan.FromSeconds(totalRequredTimeSeconds);
        
        //Print result
        Console.WriteLine(totalTime.ToString(@"d\:hh\:mm\:ss"));
    }
}