using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;

namespace A5_SecurityMisconfiguration
{
    public partial class test : System.Web.UI.Page
    {
        public string Pling = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            var list = new List<Item>();
            try
            {
                var driver = new PhantomJSDriver();
                driver.Navigate().GoToUrl($"https://www.google.se/#q={Request.QueryString["query"]}");
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
            catch (Exception)
            {
            }

            Pling = "{ \"Query\": \"" + Request.QueryString["Query"] + "\", \"Items\": []}";
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