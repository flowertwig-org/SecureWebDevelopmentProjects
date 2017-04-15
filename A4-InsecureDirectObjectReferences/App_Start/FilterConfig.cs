using System.Web;
using System.Web.Mvc;

namespace A4_InsecureDirectObjectReferences
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
