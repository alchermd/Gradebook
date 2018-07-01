using System;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Gradebook mathGradebook = new Gradebook("Math I");

            mathGradebook.AddGrade(100);
            mathGradebook.AddGrade(50);
            mathGradebook.AddGrade(75);

            GradeStatistics stats = mathGradebook.ComputeStatistics();

            Console.WriteLine($"{mathGradebook.SubjectName} Statistics");
            Console.WriteLine($"Lowest Grade: {stats.LowestGrade}");
            Console.WriteLine($"Highest Grade: {stats.HighestGrade}");
            Console.WriteLine($"Average Grade: {stats.AverageGrade}");
        }
    }
}
