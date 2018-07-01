using System;
using System.Collections.Generic;
using System.Linq;

namespace Gradebook
{
    class Gradebook
    {
        private List<double> grades = new List<double>();
        public string SubjectName { get; set; }

        public static double MinimumGrade = 0;
        public static double MaximumGrade = 100;

        public Gradebook(string subjectName)
        {
            SubjectName = subjectName;
        }

        public void AddGrade(double grade)
        {
            if (grade < MinimumGrade || grade > MaximumGrade)
            {
                throw new Exception("Grade out of bounds");
            }

            grades.Add(grade);
        }

        public GradeStatistics ComputeStatistics()
        {
            return new GradeStatistics(ComputeLowestGrade(), ComputeHighestGrade(), ComputeAverage());
        }

        private double ComputeLowestGrade()
        {
            return grades.Min();
        }

        private double ComputeHighestGrade()
        {
            return grades.Max();
        }

        private double ComputeAverage()
        {
            return grades.Average();
        }
    }
}