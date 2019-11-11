using System;
using Xunit;
using GradeBook;

namespace test
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            //arrange
            var book = new Book();
            book.AddGrade(90.5);
            book.AddGrade(95.6);
            book.AddGrade(66.9);

            var result = book.GetStatistics();

            //act

            var highestGrade = 95.6;
            var lowestGrade = 66.9;
            var averageGrade = 83.97;

            //assert
            Assert.Equal(result.High,highestGrade);
            Assert.Equal(result.Low,lowestGrade);
            Assert.Equal(result.Average,averageGrade,0);

        }
    }
}
