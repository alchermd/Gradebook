using System;
using System.Collections.Generic;

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
            if (grade <= MinimumGrade || grade >= MaximumGrade)
            {
                throw new Exception("Grade out of bounds");
            }

            grades.Add(grade);
        }

        public double ComputeAverage()
        {
            if (grades.Count > 0)
            {
                double sum = 0;

                foreach (double grade in grades)
                {
                    sum += grade;
                }

                return sum / grades.Count;
            }

            return 0;
        }
    }
}