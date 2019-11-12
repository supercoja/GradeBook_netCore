using System;
using Xunit;
using GradeBook;

namespace test
{
    public class TypeTests
    {
        Book GetBook(string name)
        {
            return new Book(name);
        }

        private void SetName(Book book, string name)
        {
            book.name = name;
        }
        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }

        private int GetInt()
        {
            return 3;
        }

        private void SetInt(int x)
        {
            x = 42;
        }

        private void SetInt(ref int z)
        {
            z = 42;
        }


        [Fact]
        private void ValueTypesAlsoPassByValue()
        {
            var x = GetInt();
            SetInt(ref x);

            Assert.Equal(42, x);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = new Book("Book 1");
            SetName(book1, "New Name");
            Assert.Equal("New Name", book1.name);
        }

        [Fact]
        public void CSharpIsSetByValue()
        {
            var book1 = new Book("Book 1");
            GetBookSetName(book1, "New Name");
            Assert.Equal("Book 1", book1.name);
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
            var book1 = new Book("Book 1");
            GetBookSetName(ref book1, "New Name");
            Assert.Equal("New Name", book1.name);
        }


        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            //arrange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            //act

            //assert
            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TowVariablesCanReferenceSameObject()
        {
            //arrange
            var book1 = GetBook("Book 1");
            var book2 = book1;

            //act

            //assert
            Assert.Same(book1, book2);
            Assert.True(object.ReferenceEquals(book1, book2));
        }
    }
}
