using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Ramki Book");
            book.AddGrade(9.3);
            book.AddGrade(10.32);
            book.AddGrade(2.1);
            book.ShowStatistics();
        }
    }
}
