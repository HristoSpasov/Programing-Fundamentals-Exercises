namespace _8.Average_Grades
{
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public string StudentName { get; set; }

        public List<double> StudentGrades { get; set; }

        public double AverageGrade => this.StudentGrades.Average();
    }
}
