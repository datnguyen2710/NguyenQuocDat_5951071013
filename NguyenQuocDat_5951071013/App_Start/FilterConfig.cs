using System.Web;
using System.Web.Mvc;

namespace NguyenQuocDat_5951071013
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
