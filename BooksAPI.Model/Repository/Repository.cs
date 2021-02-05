using BooksAPI.Model.Context;
using BooksAPI.Model.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BooksAPI.Model.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseModel
    {
        private readonly BooksAPIDBContext _context;

        public Repository(BooksAPIDBContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public bool Exists(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await Task.FromResult(_context.Set<T>());
        }

        public async Task<T> GetById(Guid id)
        {
            return await Task.FromResult(_context.Set<T>().Find(id));
        }

        public void SaveAll()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
        }
    }
}
