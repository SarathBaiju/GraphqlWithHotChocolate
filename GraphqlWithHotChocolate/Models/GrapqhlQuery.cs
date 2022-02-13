using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphqlWithHotChocolate.Models
{
    public class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
    }
    public class Author
    {
        public string Name { get; set; }
    }
    public class Query
    {
        public async Task<Book> GetBook()
        {
            return new Book
            {
                Title = "test",
                Author = new Author
                {
                    Name = "tst author"
                }
            };
        }
        public async Task<IEnumerable<Book>> GetBooks()
        {
            return new List<Book>()
            {
                new Book
                {
                    Title = "test",
                    Author = new Author
                    {
                        Name = "tst author"
                    }
                }
            };
        }
    }
}

