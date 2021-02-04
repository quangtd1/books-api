using System;
using System.Collections.Generic;
using BooksAPI.BusinessLogic.Interface;
using BooksAPI.Model.Models;
using Microsoft.AspNetCore.Mvc;

namespace BooksAPI.Controllers
{
    [Route("api/books")]
    public class BooksController : ControllerBase
    {
        private readonly IBooksRepository _repository;

        public BooksController(IBooksRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Book> GetAllBooks() => _repository.GetAllBooks();

        [HttpGet("{id}")]
        public Book GetBook(Guid id) => _repository.GetBookById(id);
    }
}
