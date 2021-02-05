using BooksAPI.Model.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BooksAPI.Model.Repository
{
    public interface IRepository<T> where T : BaseModel
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> GetById(Guid id);

        void Add(T entity);

        void Delete(T entity);

        bool Exists(Guid id);

        void SaveAll();

        void Update(T entity);
    }
}
