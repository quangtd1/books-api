using AutoMapper;
using BooksAPI.Model.Dtos;
using BooksAPI.Model.Models;
using BooksAPI.Model.Requests;

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
