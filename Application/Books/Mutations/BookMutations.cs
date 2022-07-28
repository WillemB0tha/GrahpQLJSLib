using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Books.Mutations
{
    public class BookMutations
    {
        public async Task<List<Book>> AddBook(Book book)
        {
            return Add(book);
        }

        public List<Book> Add(Book book)
        {
            var books = new List<Book>
            {
                new Book
                {
                 Id = 1,
                 Title = "The Rise of the GraphQL Warrior",
                 Score = 5,
                },
                new Book
                {
                 Id = 2,
                 Title = "The Rise of the GraphQL Warrior Part 2",
                 Score = 0,
                },
                new Book
                {
                 Id = 3,
                 Title = "Peanuts",
                 Score = 9,
                },
                book
            };
            return books; ;
        }
    }
}
