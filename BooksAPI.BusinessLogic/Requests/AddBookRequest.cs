using System;
using System.ComponentModel.DataAnnotations;

namespace BooksAPI.BusinessLogic.Requests
{
    public class AddBookRequest : BaseRequest
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public Guid AuthorId { get; set; }
    }
}
