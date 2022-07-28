using Domain.Entities;
using Persistence;

namespace Application.Books.Queries
{
    public class BookQuery
    {
        public Book GetBook() =>
            new Book
                {
                    Title = "C# in depth.",
                    Author = new Author
                {
                    Name = "Jon Skeet"
                }
            };

        public List<Book> GetBooks() => new List<Book>
        {
            new Book
          {
              Title = "C# in depth.",
              Author = new Author
              {
                  Name = "Jon Skeet"
              },
              Score = 2
          },
             new Book
          {
              Title = "C# in depth.",
              Author = new Author
              {
                  Name = "Jon Skeet"
              },
              Score = 9
          },
              new Book
          {
              Title = "C# in depth.",
              Author = new Author
              {
                  Name = "Jon Skeet"
              },
              Score = 4
          }
        };          

        public Book GetBookById(int id) =>       
             Seed.SeedData().FirstOrDefault(x => x.Id == id);

        public List<Book> GetBookScoresAbove(int num) =>
            Seed.SeedData().Where(x => x.Score > num).ToList();

    }   
}
 