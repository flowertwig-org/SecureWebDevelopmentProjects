using System.Web;
using System.Web.Mvc;

namespace A6_SensitiveDataExposure
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
