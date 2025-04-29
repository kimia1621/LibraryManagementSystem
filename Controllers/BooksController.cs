using LibraryManagementSystem.DTOs;
using LibraryManagementSystem.Services;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult GetBooks()
        {
            var books = _bookService.GetAllBooks();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public IActionResult GetBook(int id)
        {
            var book = _bookService.GetBookById(id);
            if (book == null) return NotFound();
            return Ok(book);
        }

        [HttpPost]
        public IActionResult CreateBook([FromBody] BookDto bookDto)
        {
            _bookService.AddBook(bookDto);
            return CreatedAtAction(nameof(GetBook), new { id = 1 }, bookDto); // باید id واقعی به پارامتر داده شود
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, [FromBody] BookDto bookDto)
        {
            _bookService.UpdateBook(id, bookDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            _bookService.DeleteBook(id);
            return NoContent();
        }
    }

}
