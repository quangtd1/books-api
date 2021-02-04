using BooksAPI.Model.Dtos;
using BooksAPI.Model.Requests;
using System;
using System.Collections.Generic;

namespace BooksAPI.BusinessLogic.Interface
{
    public interface IBooksRepository
    {
        IEnumerable<BookDto> GetAllBooks();

        BookDto GetBookById(Guid id);

        BookDto AddBook(AddBookRequest request);

        BookDto UpdateBook(Guid id, UpdateBookRequest request);

        void DeteleBook(Guid id);
    }
}
