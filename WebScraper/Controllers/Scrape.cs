using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CsvHelper;
using HtmlAgilityPack;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace WebScraper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Scrape : ControllerBase
    {
        [HttpPost(Name = "ScrapeIt")]
        public List<Row> StartScrape()
        {
            Methods method = new Methods();
            method.ScrapeThatWebsite();
            return null;
        }
    }

    public class Methods
    {
        public void ScrapeThatWebsite()
        {
            //Get the content of the URL from the Web
            const string url = "https://www.pricecheck.co.za/daily-deals";
            var web = new HtmlWeb();
            var doc = web.Load(url);

            //Get the content from a file
            //var path = "countries.html";
            //var doc = new HtmlDocument();
            //doc.Load(path);

            //Filter the content
            doc.DocumentNode.Descendants()
                            .Where(n => n.Name == "script")
                            .ToList()
                            .ForEach(n => n.Remove());

            const string classValue = "container";
            var nodes = doc.DocumentNode.SelectNodes($"//*[@class='{classValue}']") ?? Enumerable.Empty<HtmlNode>();
        }
    }

    public class Row 
    { 
        public string Title { get; set; } 
    }


}
