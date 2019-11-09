using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.AddGrade(50.3);
            book.AddGrade(40.5);
            book.AddGrade(50.6);
            book.AddGrade(90.7);

            book.ShowStatistics();
        }
    }
}
