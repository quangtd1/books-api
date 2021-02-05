using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BooksAPI.BusinessLogic.Dtos;
using BooksAPI.BusinessLogic.Interface;
using BooksAPI.BusinessLogic.Requests;
using Microsoft.AspNetCore.Mvc;

namespace BooksAPI.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBooksRepository _repository;

        public BooksController(IBooksRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public Task<IEnumerable<BookDto>> GetAllBooks() => _repository.GetAllBooks();

        [HttpGet("{id}")]
        public Task<BookDto> GetBook(Guid id) => _repository.GetBookById(id);

        [HttpPost]
        public Task<BookDto> CreateBook(AddBookRequest request) => _repository.AddBook(request);

        [HttpPut("{id}")]
        public Task<BookDto> UpdateBook(Guid id, UpdateBookRequest request) => _repository.UpdateBook(id, request);

        [HttpDelete("{id}")]
        public void DeleteBook(Guid id) => _repository.DeteleBook(id);
    }
}
