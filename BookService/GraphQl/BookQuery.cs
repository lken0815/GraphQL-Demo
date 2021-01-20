using System.Collections.Generic;

namespace BookService.GraphQl
{
    public class BookQuery
    {
        public IEnumerable<Book> GetBooks(IEnumerable<string> bookIds)
        {
            var result = new List<Book>();

            foreach (var id in bookIds)
            {
                result.Add(
                    new Book()
                    {
                        BookId = id,
                        BookTitle = "Test-Book",
                    });
            }

            return result;
        }

        public Book GetBook(string bookId)
        {
            return new Book()
            {
                BookId = bookId,
                BookTitle = "Test-Book",
            };
        }

        public IEnumerable<Book> GetBooksByNumber(IEnumerable<int> numbers)
        {
            var result = new List<Book>();

            foreach (var number in numbers)
            {
                result.Add(
                    new Book()
                    {
                        BookTitle = "Test-Book",
                        BookId = number.ToString(),
                    });
            }

            return result;
        }
    }
}
