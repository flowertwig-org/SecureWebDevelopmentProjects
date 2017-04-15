using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;

namespace A5_SecurityMisconfiguration_EpiServer.Controllers
{
    public class SearchResultController : Controller
    {
        // GET: Search

        public class SearchRequest
        {
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

        public ActionResult Index(SearchRequest req)
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
    }
}