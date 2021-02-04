using System;
using System.ComponentModel.DataAnnotations;

namespace BooksAPI.Model.Models
{
    public class BaseModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
