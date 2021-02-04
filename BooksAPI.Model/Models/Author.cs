﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BooksAPI.Model.Models
{
    public class Author : BaseModel
    {
        public DateTime? Birthday { get; set; }

        [MaxLength(12)]
        public string PhoneNumber { get; set; }

        public string Website { get; set; }

        public ICollection<Book> Books { get; set; }
            = new List<Book>();
    }
}
