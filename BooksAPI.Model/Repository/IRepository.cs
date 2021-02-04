﻿using BooksAPI.Model.Models;
using System;
using System.Collections.Generic;

namespace BooksAPI.Model.Repository
{
    public interface IRepository<T> where T : BaseModel
    {
        IEnumerable<T> GetAll();

        T GetById(Guid id);

        void Add(T entity);

        void Delete(T entity);

        bool Exists(Guid id);
    }
}
