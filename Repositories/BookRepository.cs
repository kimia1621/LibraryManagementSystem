using LibraryManagementSystem.Models;
using LibraryManagementSystem.Services;

namespace LibraryManagementSystem.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly List<Book> _books;

        public BookRepository()
        {
            // داده‌های پیش‌فرض
            _books = new List<Book>
        {
            new Book { Id = 1, Title = "C# Programming", Author = "John Doe", ISBN = "123456789" },
            new Book { Id = 2, Title = "ASP.NET Core for Beginners", Author = "Jane Smith", ISBN = "987654321" }
        };
        }

        public IEnumerable<Book> GetAllBooks() => _books;

        public Book GetBookById(int id) => _books.FirstOrDefault(b => b.Id == id);

        public void AddBook(Book book) => _books.Add(book);

        public void UpdateBook(Book book)
        {
            var existingBook = GetBookById(book.Id);
            if (existingBook != null)
            {
                existingBook.Title = book.Title;
                existingBook.Author = book.Author;
                existingBook.ISBN = book.ISBN;
            }
        }

        public void DeleteBook(int id) => _books.RemoveAll(b => b.Id == id);
    }

}
