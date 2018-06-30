using System;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Gradebook mathGradebook = new Gradebook("Math I");

            mathGradebook.AddGrade(100);
            mathGradebook.AddGrade(100);
            mathGradebook.AddGrade(100);

            Console.WriteLine($"Average for {mathGradebook.subjectName}: {mathGradebook.ComputeAverage()}");
        }
    }
}
