using BooksAPI.Model.Models;
using BooksAPI.Model.Request;
using System;
using System.Collections.Generic;

namespace BooksAPI.BusinessLogic.Interface
{
    public interface IBooksRepository
    {
        IEnumerable<Book> GetAllBooks();

        Book GetBookById(Guid id);

        IEnumerable<Book> AddBook(AddBookRequest request);
    }
}
