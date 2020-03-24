using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverage()
        {
            //arrange variables
            var book = new Book("");
            book.AddGrade(4.2);
            book.AddGrade(12.3);

            //action 
            book.ShowStatistics();

        }
    }
}
