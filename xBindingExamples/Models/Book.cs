using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xBindingExamples.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CoverImage { get; set; }
    }
    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();
            books.Add(new Book { BookId = 1, Title = "Vulpate", Author = "Futurum", CoverImage = "Assets/drinks/1.jpeg" });
            books.Add(new Book { BookId = 2, Title = "Mazim", Author = "Sequiter Que", CoverImage = "Assets/books/2.png" });
            books.Add(new Book { BookId = 3, Title = "Elit", Author = "Tempor", CoverImage = "Assets/books/3.png" });
            books.Add(new Book { BookId = 4, Title = "Vulpate", Author = "Futurum", CoverImage = "Assets/books/4.png" });
            books.Add(new Book { BookId = 5, Title = "Vulpate", Author = "Futurum", CoverImage = "Assets/books/5.png" });
            books.Add(new Book { BookId = 6, Title = "Vulpate", Author = "Futurum", CoverImage = "Assets/books/6.png" });
            books.Add(new Book { BookId = 7, Title = "Vulpate", Author = "Futurum", CoverImage = "Assets/books/7.png" });
            books.Add(new Book { BookId = 8, Title = "Vulpate", Author = "Futurum", CoverImage = "Assets/books/8.png" });
            books.Add(new Book { BookId = 9, Title = "Vulpate", Author = "Futurum", CoverImage = "Assets/books/9.png" });
            books.Add(new Book { BookId = 10, Title = "Vulpate", Author = "Futurum", CoverImage = "Assets/books/10.png" });
            books.Add(new Book { BookId = 11, Title = "Vulpate", Author = "Futurum", CoverImage = "Assets/books/11.png" });
            books.Add(new Book { BookId = 12, Title = "Vulpate", Author = "Futurum", CoverImage = "Assets/books/12.png" });
            books.Add(new Book { BookId = 13, Title = "Vulpate", Author = "Futurum", CoverImage = "Assets/books/13.png" });

            return books;
        }
    }
}
