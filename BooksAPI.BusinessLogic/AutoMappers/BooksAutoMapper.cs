using AutoMapper;
using BooksAPI.BusinessLogic.Dtos;
using BooksAPI.BusinessLogic.Requests;
using BooksAPI.Model.Models;

namespace BooksAPI.BusinessLogic.AutoMappers
{
    public class BooksAutoMapper : Profile
    {
        public BooksAutoMapper()
        {
            CreateMap<Book, BookDto>();
            CreateMap<AddBookRequest, Book>();
            CreateMap<UpdateBookRequest, Book>();
        }
    }
}
