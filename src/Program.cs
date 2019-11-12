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

            var done=false;

            while(!done)
            {
                Console.WriteLine("Enter a Grade or 'q' to quit");
                var input = Console.ReadLine();
                Console.WriteLine(input);

                if (input=="q")
                {
                    break;
                }

                try 
                {
                var grade = double.Parse(input);
                book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Argumento Inválido: {ex.Message}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Formato Inválido: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Valor Inválido: {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("Fim");
                }
            }

            var statisticsGrade = book.GetStatistics();

            Console.WriteLine($"Average Grade: {statisticsGrade.Average:N1}");
            Console.WriteLine($"Lowest Grade: {statisticsGrade.Low:N1}");
            Console.WriteLine($"Highest Grade: {statisticsGrade.High:N1}");
            Console.WriteLine($"Highest Grade: {statisticsGrade.Letter}");

        }
    }
}
