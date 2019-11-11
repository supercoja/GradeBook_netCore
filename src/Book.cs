using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book()
        {
            grades = new List<double>();
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();

            result.Average = 0.00;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (var grade in grades)
            {
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade, result.Low);
                result.Average += grade;
            }
            result.Average /= grades.Count;

            return result;
        }

        public void ShowStatistics()
        {
            // Console.WriteLine($"Average Grade: {result:N1}");
            // Console.WriteLine($"Lowest Grade: {lowestGrade:N1}");
            // Console.WriteLine($"Highest Grade: {highestGrade:N1}");
        }

        List<double> grades;
        protected string name { get; private set; }
    }
}