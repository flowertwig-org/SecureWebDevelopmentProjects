using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.PhantomJS;

namespace A3_XSS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public class SearchRequest
        {
            [AllowHtml]
            public string Query { get; set; }
        }

        public ActionResult Search(SearchRequest req)
        {
            var list = new List<Item>();
            try
            {
                var driver = new PhantomJSDriver();
                driver.Navigate().GoToUrl($"https://www.google.se/#q={req.Query}");
                var elements = driver.FindElementsByClassName("g");

                foreach (var element in elements)
                {
                    var link = element.FindElement(By.TagName("a")).GetAttribute("href");
                    var header = element.FindElement(By.TagName("h3")).Text;
                    list.Add(new Item
                    {
                        Header = header,
                        Url = link
                    });
                }
            }
            catch (Exception e)
            {
            }

            return this.Json(new Result
            {
                Query = req.Query,
                Items = list.ToArray()
            }, JsonRequestBehavior.AllowGet);
        }

        public class Result
        {
            public string Query { get; set; }
            public Item[] Items { get; set; }
        }

        public class Item
        {
            public string Header { get; set; }
            public string Url { get; set; }
        }
    }
}