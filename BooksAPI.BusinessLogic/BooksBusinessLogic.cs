using BooksAPI.BusinessLogic.Interface;
using BooksAPI.Model.Models;
using BooksAPI.Model.Repository;
using BooksAPI.Model.Request;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BooksAPI.BusinessLogic
{
    public class BooksBusinessLogic : IBooksRepository
    {
        private readonly IRepository<Book> _repository;

        public BooksBusinessLogic(IRepository<Book> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Book> AddBook(AddBookRequest request)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAllBooks() => _repository.GetAll();

        public Book GetBookById(Guid id) => _repository.GetById(id);
    }
}
