using BooksAPI.BusinessLogic.Interface;
using BooksAPI.Model.Models;
using System;

namespace BooksAPI.BusinessLogic.Exceptions
{
    public class ThroughException<T> : IThroughException<T> where T : BaseModel
    {
        public void CheckExistItem(string name, T entity)
        {
            if (entity == null) throw new BadRequestException(name + " not found!");
        }
    }
}
