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
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);

        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
        
        [Fact]
        public void Test2()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Book");

            Assert.Equal("New Book",book1.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void Test3()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Book");

            Assert.Equal("Book 1",book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
            book.Name = name;
        }

        [Fact]
        public void Test4()
        {
            var book1 = GetBook("Book 1");
            GetBookSetNamebyRef(ref book1, "New Book");

            Assert.Equal("New Book",book1.Name);
        }

        private void GetBookSetNamebyRef(ref Book book, string name)
        {
            book = new Book(name);
            book.Name = name;
        }

        [Fact]
        public void Test5()
        {
            var x = GetInt();            
            Assert.Equal(3, x);
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void Test6()
        {
            var x = GetInt();
            SetInt(ref x);

            Assert.Equal(42, x);
        }

        private void SetInt(ref int z)
        {
            z = 42;
        }
    }
}
