using Application.Scraper.Services;
using Domain.Entities;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Feeds.Queries
{
    public class FeedQuery
    {
        public Feed GetFeedByName(String title)
        {
            ScraperService method = new ScraperService();
            return method.ScrapeThatWebsite().FirstOrDefault(x => x.Title == title); ;
        }

        public List<Feed> GetFeeds()
        {
            ScraperService method = new ScraperService();
            return method.ScrapeThatWebsite() ;
        }

        //   public Book GetBookById(int id) =>
        //Seed.SeedData()
    }
}
