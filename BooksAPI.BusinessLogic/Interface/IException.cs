using BooksAPI.Model.Models;
using System;

namespace BooksAPI.BusinessLogic.Interface
{
    public interface IException<T> where T : BaseModel
    {
        public void CheckExistItem(string name, T entity);
    }
}
