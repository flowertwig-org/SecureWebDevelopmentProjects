using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer.Core;
using EPiServer.Framework.Web;
using EPiServer.Search;
using A5_SecurityMisconfiguration_EpiServer.Business;
using A5_SecurityMisconfiguration_EpiServer.Models.Pages;
using A5_SecurityMisconfiguration_EpiServer.Models.ViewModels;
using EPiServer.Web;
using EPiServer.Web.Hosting;
using EPiServer.Web.Mvc.Html;
using EPiServer.Web.Routing;
using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;

namespace A5_SecurityMisconfiguration_EpiServer.Controllers
{
    public class SearchPageController : PageControllerBase<SearchPage>
    {
        private const int MaxResults = 40;
        private readonly SearchService _searchService;
        private readonly ContentSearchHandler _contentSearchHandler;
        private readonly UrlResolver _urlResolver;
        private readonly TemplateResolver _templateResolver;

        public SearchPageController(
            SearchService searchService, 
            ContentSearchHandler contentSearchHandler, 
            TemplateResolver templateResolver,
            UrlResolver urlResolver)
        {
            _searchService = searchService;
            _contentSearchHandler = contentSearchHandler;
            _templateResolver = templateResolver;
            _urlResolver = urlResolver;
        }

        public ViewResult Index(SearchPage currentPage)
        {
            var model = new SearchContentModel(currentPage);

            return View(model);
        }
    }
}
