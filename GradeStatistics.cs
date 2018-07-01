namespace Gradebook
{
    internal class GradeStatistics
    {
        public double LowestGrade { get; }
        public double HighestGrade { get; }
        public double AverageGrade { get; }

        public GradeStatistics(double lowestGrade, double highestGrade, double averageGrade)
        {
            LowestGrade = lowestGrade;
            HighestGrade = highestGrade;
            AverageGrade = averageGrade;
        }
    }
}