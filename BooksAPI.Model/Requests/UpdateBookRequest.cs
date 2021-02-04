using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BooksAPI.Model.Requests
{
    public class UpdateBookRequest : BaseRequest
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
