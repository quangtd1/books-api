using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksAPI.Model.Models
{
    public class Book : BaseModel
    {
        [Required]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int Year { get; set; }


        [ForeignKey(nameof(AuthorId))]
        public Author Author { get; set; }

        public Guid AuthorId { get; set; }
    }
}
