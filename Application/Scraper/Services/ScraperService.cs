using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Application.Scraper.Services
{
    public class ScraperService
    {

        public List<Feed> ScrapeThatWebsite()
        {
            CultureInfo culture = new("en-US");

            List<Feed> feeds = new List<Feed>();

            List<string> authorIds = new List<string>()
            {
                "sarath-lal7",
                "mahesh-chand",
                "vijai-anand-ramalingam",
                "vulpes",
                "manpreet-singh12",
                "jignesh-trivedi",
                "debasis-saha",
                "rohatash-kumar",
                "nitin-pandit",
                "raj-kumar-beniwal",
                "sarath-lal7",
                "mahesh-chand",
                "vijai-anand-ramalingam",
                "vulpes",
                "manpreet-singh12",
                "jignesh-trivedi",
                "debasis-saha",
                "rohatash-kumar",
                "nitin-pandit",
                "sarath-lal7",
                "mahesh-chand",
                "vijai-anand-ramalingam",
                "vulpes",
                "manpreet-singh12",
                "jignesh-trivedi",
                "debasis-saha",
                "rohatash-kumar",
                "nitin-pandit",
                "sarath-lal7",
                "mahesh-chand",
                "vijai-anand-ramalingam",
                "vulpes",
                "manpreet-singh12",
                "jignesh-trivedi",
                "debasis-saha",
                "rohatash-kumar",
                "nitin-pandit",
                "sarath-lal7",
                "mahesh-chand",
                "vijai-anand-ramalingam",
                "vulpes",
                "manpreet-singh12",
                "jignesh-trivedi",
                "debasis-saha",
                "rohatash-kumar",
                "nitin-pandit",
                "sarath-lal7",
                "mahesh-chand",
                "vijai-anand-ramalingam",
                "vulpes",
                "manpreet-singh12",
                "jignesh-trivedi",
                "debasis-saha",
                "rohatash-kumar",
                "nitin-pandit",
                "sarath-lal7",
                "mahesh-chand",
                "vijai-anand-ramalingam",
                "vulpes",
                "manpreet-singh12",
                "jignesh-trivedi",
                "debasis-saha",
                "rohatash-kumar",
                "nitin-pandit",
                "sarath-lal7",
                "mahesh-chand",
                "vijai-anand-ramalingam",
                "vulpes",
                "manpreet-singh12",
                "jignesh-trivedi",
                "debasis-saha",
                "rohatash-kumar",
                "nitin-pandit",
                "sarath-lal7",
                "mahesh-chand",
                "vijai-anand-ramalingam",
                "vulpes",
                "manpreet-singh12",
                "jignesh-trivedi",
                "debasis-saha",
                "rohatash-kumar",
                "nitin-pandit",
                "sarath-lal7",
                "mahesh-chand",
                "vijai-anand-ramalingam",
                "vulpes",
                "manpreet-singh12",
                "jignesh-trivedi",
                "debasis-saha",
                "rohatash-kumar",
                "nitin-pandit"
            };

            Parallel.ForEach(authorIds, new ParallelOptions { MaxDegreeOfParallelism = 1000 }, author =>
            {
                XDocument authorDoc = XDocument.Load("https://www.c-sharpcorner.com/members/" + author + "/rss");

                var entries = from item in authorDoc.Root.Descendants().First(i => i.Name.LocalName == "channel").Elements().Where(i => i.Name.LocalName == "item")
                              select new Feed
                              {
                                  Content = item.Elements().First(i => i.Name.LocalName == "description").Value,
                                  Link = (item.Elements().First(i => i.Name.LocalName == "link").Value).StartsWith("/") ? "https://www.c-sharpcorner.com" + item.Elements().First(i => i.Name.LocalName == "link").Value : item.Elements().First(i => i.Name.LocalName == "link").Value,
                                  PubDate = Convert.ToDateTime(item.Elements().First(i => i.Name.LocalName == "pubDate").Value, culture),
                                  Title = item.Elements().First(i => i.Name.LocalName == "title").Value,
                                  FeedType = (item.Elements().First(i => i.Name.LocalName == "link").Value).ToLowerInvariant().Contains("blog") ? "Blog" : (item.Elements().First(i => i.Name.LocalName == "link").Value).ToLowerInvariant().Contains("news") ? "News" : "Article",
                                  Author = item.Elements().First(i => i.Name.LocalName == "author").Value
                              };

                feeds = entries.OrderByDescending(o => o.PubDate).ToList();

                Console.WriteLine("Feeds Found, {0} for Author {1}", feeds.Count, author);


            });

            return feeds;
        }
    }
}
