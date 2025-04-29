using LibraryManagementSystem.DTOs;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBookById(int id);
        void AddBook(BookDto bookDto);
        void UpdateBook(int id, BookDto bookDto);
        void DeleteBook(int id);
    }
}
