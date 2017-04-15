using System.Web;
using System.Web.Mvc;

namespace A8_CrossSiteRequestForgery
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
