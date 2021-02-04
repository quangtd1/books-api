using System;

namespace BooksAPI.Model.Dtos
{
    public class BookDto: BaseDto
    {
        public string Description { get; set; }

        public double Price { get; set; }

        public int Year { get; set; }

        public Guid AuthorId { get; set; }
    }
}
