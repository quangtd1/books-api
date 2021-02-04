using BooksAPI.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksAPI.Model.Context
{
    public class BooksAPIDBContext : DbContext
    {
        public BooksAPIDBContext(DbContextOptions<BooksAPIDBContext> opt) : base(opt)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
