namespace _4.Average_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// Print students alphabetically with average grade more than 5
    public class Program
    {
        public static void Main(string[] args)
        {
            int totalStudens = int.Parse(Console.ReadLine());

            var studentAverageList = new List<Student>();

            /// Loop over to get name and grades for each student
            for (int i = 0; i < totalStudens; i++)
            {
                /// Split data for current student
                string[] currStudent = Console.ReadLine()
                    .Split();

                /// Save all grades to list
                List<double> grades = new List<double>();

                for (int j = 1; j < currStudent.Length; j++)
                {
                    grades.Add(double.Parse(currStudent[j]));
                }

                /// Set values for student in Student.cs
                Student currentStudent = new Student
                {
                    StudentName = currStudent[0],
                    Grades = grades   
                };

                /// Add current user to list
                studentAverageList.Add(currentStudent);
            }
            
            /// Print alphabetically all students with mark over 5
            foreach (var student in studentAverageList.Where(x => x.AverageGrade >= 5.00)
                                                      .OrderBy(x => x.StudentName)
                                                      .ThenByDescending(x => x.AverageGrade))
            {
                Console.WriteLine($"{student.StudentName} -> {student.AverageGrade:F2}");
            }
        }
    }
}