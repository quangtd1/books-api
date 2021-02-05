using BooksAPI.BusinessLogic.Interface;
using BooksAPI.Model.Models;
using System;

namespace BooksAPI.BusinessLogic.Exceptions
{
    public class Exception<T> : IException<T> where T : BaseModel
    {
        public void CheckExistItem(string name, T entity)
        {
            if (entity == null) throw new BadRequestException(name + " not found!");
        }
    }
}
