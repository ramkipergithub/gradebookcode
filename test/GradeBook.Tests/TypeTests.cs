using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void Test1()
        {
            var book1 = GetBook("Book 1");

        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
