using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            //arrange variables
            var book = new Book("");
            book.AddGrade(4.2);
            book.AddGrade(12.3);


            //action 
            book.ShowStatistics();


            //assertion





            
            /*
            var x = 5;
            var y = 2;
            var expected = 7;
            //var actual = x * y; //this will fail as the actual and expected wouldn't match
            var actual = x + y;

            Assert.Equal(expected, actual);
            */
            

        }
    }
}
