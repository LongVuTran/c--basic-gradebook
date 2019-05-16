using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("Vu's grade book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.4);
            
            var stats = book.GetStatistics();

            Console.WriteLine($"THe lowest grade is {stats.Low}");
            Console.WriteLine($"THe highest grade is {stats.High}");
            Console.WriteLine($"THe average grade is {stats.Average:N1}");
            
        }
    }
}
