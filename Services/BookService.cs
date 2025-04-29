using LibraryManagementSystem.DTOs;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Services
{
   public class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }


    public IEnumerable<Book> GetAllBooks() => _bookRepository.GetAllBooks();

    public Book GetBookById(int id) => _bookRepository.GetBookById(id);

    public void AddBook(BookDto bookDto)
    {
        var book = new Book
        {
            Title = bookDto.Title,
            Author = bookDto.Author,
            ISBN = bookDto.ISBN
        };
        _bookRepository.AddBook(book);
    }

    public void UpdateBook(int id, BookDto bookDto)
    {
        var book = _bookRepository.GetBookById(id);
        if (book != null)
        {
            book.Title = bookDto.Title;
            book.Author = bookDto.Author;
            book.ISBN = bookDto.ISBN;
            _bookRepository.UpdateBook(book);
        }
    }

    public void DeleteBook(int id) => _bookRepository.DeleteBook(id);
}

}
