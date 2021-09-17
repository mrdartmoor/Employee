using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pracownicy.Models
{
        public class Book
        {
            public int BookId { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public ICollection<BookCategory> BookCategories { get; set; }
        }
        public class Category
        {
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }
            public ICollection<BookCategory> BookCategories { get; set; }
        }
        public class BookCategory
        {
            public int BookId { get; set; }
            public Book Book { get; set; }
            public int CategoryId { get; set; }
            public Category Category { get; set; }
        }
    
}
