using Domain.Entities;

namespace Persistence
{
    public class Seed
    {
        public static List<Book> SeedData()
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

            };
            return books;;
        }
    }
}