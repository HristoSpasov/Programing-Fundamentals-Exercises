namespace _8.Average_Grades
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] input = File.ReadAllLines("./StudentsGradeList.txt");

            List<Student> averageGrades = new List<Student>();

            foreach (var student in input)
            {
                string[] currStudentData = student.Split();
                string currStudentName = currStudentData[0];
                List<double> currStudentGrades = new List<double>();

                for (int i = 1; i < currStudentData.Count(); i++)
                {
                    currStudentGrades.Add(double.Parse(currStudentData[i]));
                }

                Student currStudent = new Student
                {
                    StudentName = currStudentName,
                    StudentGrades = currStudentGrades
                };

                averageGrades.Add(currStudent);
            }

            if (File.Exists("./Output.txt"))
            {
                File.Delete("./Output.txt");
            }

            foreach (var averageGrade in averageGrades.Where(x => x.AverageGrade > 5.00)
                .OrderBy(x => x.StudentName)
                .ThenByDescending(x => x.AverageGrade))
            {
                File.AppendAllText("./Output.txt", $"{averageGrade.StudentName} -> {averageGrade.AverageGrade:F2}\r\n");
            }
        }
    }
}
