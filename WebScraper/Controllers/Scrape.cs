using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CsvHelper;
using HtmlAgilityPack;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.Linq;
using System.Text.Json;
using Application.Scraper.Services;

namespace WebScraper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Scrape : ControllerBase
    {
        [HttpPost(Name = "ScrapeIt")]
        public List<Feed> StartScrape()
        {
            ScraperService method = new ScraperService();
            return method.ScrapeThatWebsite();
        }
    }

}
