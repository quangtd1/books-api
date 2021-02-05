using BooksAPI.BusinessLogic.Dtos;
using BooksAPI.BusinessLogic.Requests;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BooksAPI.BusinessLogic.Interface
{
    public interface IBooksRepository
    {
        Task<IEnumerable<BookDto>> GetAllBooks();

        Task<BookDto> GetBookById(Guid id);

        Task<BookDto> AddBook(AddBookRequest request);

        Task<BookDto> UpdateBook(Guid id, UpdateBookRequest request);

        void DeteleBook(Guid id);
    }
}
