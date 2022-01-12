using System.Web;
using System.Web.Mvc;

namespace ASP.Net_FrameworkMVC_Week5
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
