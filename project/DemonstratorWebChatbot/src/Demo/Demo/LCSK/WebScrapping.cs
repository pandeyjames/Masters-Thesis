//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using IronWebScraper;


//namespace Demo.LCSK
//{
//    class MainClass
//    {
//        public static void Main(string[] args)
//        {
//            var scraper = new Scrapper();
//            scraper.Start();
//        }
//    }
//    public class Scrapper:WebScraper
//    {
//        public override void Init()
//        {
//            this.LoggingLevel = WebScraper.LogLevel.All;
//            this.Request("https://blog.scrapinghub.com", Parse);
//        }

//        public override void Parse(Response response)
//        {
//            foreach (var title_link in response.Css("h2.entry-title a"))
//            {
//                string strTitle = title_link.TextContentClean;
//                Scrape(new ScrapedData() { { "Title", strTitle } });
//            }

//            if (response.CssExists("div.prev-post > a[href]"))
//            {
//                var next_page = response.Css("div.prev-post > a[href]")[0].Attributes["href"];
//                this.Request(next_page, Parse);
//            }
//        }
//    }
//}