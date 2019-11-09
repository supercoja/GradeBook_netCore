using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        public Book()
        {
            grades = new List<double>();
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var result = 0.00;
            var highGrade = double.MinValue;
            var lowestGrade = double.MaxValue;

            foreach (var number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowestGrade = Math.Min(number, lowestGrade);
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"Average Grade: {result:N1}");
            Console.WriteLine($"Lowest Grade: {lowestGrade:N1}");
            Console.WriteLine($"Highest Grade: {highGrade:N1}");
        }


        List<double> grades;

    }
}