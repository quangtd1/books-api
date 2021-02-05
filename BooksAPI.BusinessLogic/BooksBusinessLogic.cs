using AutoMapper;
using BooksAPI.BusinessLogic.Dtos;
using BooksAPI.BusinessLogic.Interface;
using BooksAPI.BusinessLogic.Requests;
using BooksAPI.Model.Models;
using BooksAPI.Model.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BooksAPI.BusinessLogic
{
    public class BooksBusinessLogic : IBooksRepository
    {
        private readonly IRepository<Book> _repositoryBook;
        private readonly IRepository<Author> _repositoryAuthor;
        private readonly IMapper _mapper;
        private readonly IException<Book> _exceptionBook;
        private readonly IException<Author> _exceptionAuthor;

        private readonly string Author = "Author";
        private readonly string Book = "Book";

        public BooksBusinessLogic
            (
            IRepository<Book> repositoryBook,
            IRepository<Author> repositoryAuthor,
            IMapper mapper,
            IException<Book> exceptionBook,
            IException<Author> exceptionAuthor
            )
        {
            _repositoryBook = repositoryBook;
            _repositoryAuthor = repositoryAuthor;
            _mapper = mapper;
            _exceptionBook = exceptionBook;
            _exceptionAuthor = exceptionAuthor;
        }

        public async Task<BookDto> AddBook(AddBookRequest request)
        {
            var author = await _repositoryAuthor.GetById(request.AuthorId);
            _exceptionAuthor.CheckExistItem(Author, author);

            var bookModel = _mapper.Map<Book>(request);

            _repositoryBook.Add(bookModel);

            return _mapper.Map<BookDto>(bookModel);
        }

        public async void DeteleBook(Guid id)
        {
            var book = await _repositoryBook.GetById(id);

            _exceptionBook.CheckExistItem(Book, book);
            _repositoryBook.Delete(book);
        }

        public async Task<IEnumerable<BookDto>> GetAllBooks()
        {
            var books = await _repositoryBook.GetAll();

            return _mapper.Map<IEnumerable<BookDto>>(books);
        }

        public async Task<BookDto> GetBookById(Guid id)
        {
            var book = await _repositoryBook.GetById(id);
            _exceptionBook.CheckExistItem(Book, book);

            return _mapper.Map<BookDto>(book);
        }

        public async Task<BookDto> UpdateBook(Guid id, UpdateBookRequest request)
        {
            var author = await _repositoryAuthor.GetById(request.AuthorId);
            _exceptionAuthor.CheckExistItem(Author, author);

            var book = await _repositoryBook.GetById(id);

            _exceptionBook.CheckExistItem(Book, book);

            _mapper.Map(request, book);
            _repositoryBook.Update(book);
            _repositoryBook.SaveAll();

            return _mapper.Map<BookDto>(book);
        }
    }
}
