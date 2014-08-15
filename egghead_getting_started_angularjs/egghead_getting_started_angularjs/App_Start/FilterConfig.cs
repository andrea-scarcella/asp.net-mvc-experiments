using System.Web;
using System.Web.Mvc;

namespace egghead_getting_started_angularjs
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
