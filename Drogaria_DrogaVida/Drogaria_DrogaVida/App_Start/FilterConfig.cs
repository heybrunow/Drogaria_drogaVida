using System.Web;
using System.Web.Mvc;

namespace Drogaria_DrogaVida
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
