using AutoMapper;
using BooksAPI.BusinessLogic.Interface;
using BooksAPI.Model.Dtos;
using BooksAPI.Model.Models;
using BooksAPI.Model.Repository;
using BooksAPI.Model.Requests;
using System;
using System.Collections.Generic;

namespace BooksAPI.BusinessLogic
{
    public class BooksBusinessLogic : IBooksRepository
    {
        private readonly IRepository<Book> _repositoryBook;
        private readonly IRepository<Author> _repositoryAuthor;
        private readonly IMapper _mapper;
        private readonly IThroughException<Book> _exceptionBook;
        private readonly IThroughException<Author> _exceptionAuthor;

        private readonly string Author = "Author";
        private readonly string Book = "Book";

        public BooksBusinessLogic
            (
            IRepository<Book> repositoryBook,
            IRepository<Author> repositoryAuthor,
            IMapper mapper,
            IThroughException<Book> exceptionBook,
            IThroughException<Author> exceptionAuthor
            )
        {
            _repositoryBook = repositoryBook;
            _repositoryAuthor = repositoryAuthor;
            _mapper = mapper;
            _exceptionBook = exceptionBook;
            _exceptionAuthor = exceptionAuthor;
        }

        public BookDto AddBook(AddBookRequest request)
        {
            var author = _repositoryAuthor.GetById(request.AuthorId);
            _exceptionAuthor.CheckExistItem(Author, author);

            var bookModel = _mapper.Map<Book>(request);

            _repositoryBook.Add(bookModel);

            return _mapper.Map<BookDto>(bookModel);
        }

        public void DeteleBook(Guid id)
        {
            var book = _repositoryBook.GetById(id);

            _exceptionBook.CheckExistItem(Book, book);
            _repositoryBook.Delete(book);
        }

        public IEnumerable<BookDto> GetAllBooks()
        {
            var books = _repositoryBook.GetAll();

            return _mapper.Map<IEnumerable<BookDto>>(books);
        }

        public BookDto GetBookById(Guid id)
        {
            var book = _repositoryBook.GetById(id);
            _exceptionBook.CheckExistItem(Book, book);

            return _mapper.Map<BookDto>(book);
        }

        public BookDto UpdateBook(Guid id, UpdateBookRequest request)
        {
            var author = _repositoryAuthor.GetById(request.AuthorId);
            _exceptionAuthor.CheckExistItem(Author, author);

            var book = _repositoryBook.GetById(id);

            _exceptionBook.CheckExistItem(Book, book);

            _mapper.Map(request, book);
            _repositoryBook.Update(book);
            _repositoryBook.SaveAll();

            return _mapper.Map<BookDto>(book);
        }
    }
}
