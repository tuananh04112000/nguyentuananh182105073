using System.Web;
using System.Web.Mvc;

namespace nguyentuananh1821050738
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
