using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Gradebook
    {
        private List<double> grades = new List<double>();
        public string SubjectName { get; set; }

        public Gradebook(string subjectName)
        {
            SubjectName = subjectName;
        }

        public void AddGrade(double grade)
        {
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