using System.Web;
using System.Web.Mvc;

namespace A2_BrokenAuthenticationAndSessionManagement
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
