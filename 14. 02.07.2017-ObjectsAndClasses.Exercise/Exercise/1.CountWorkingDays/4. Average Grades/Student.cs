﻿namespace _4.Average_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public string StudentName { get; set; }

        public List<double> Grades { get; set; }

        public double AverageGrade => this.Grades.Average();
    }
}
