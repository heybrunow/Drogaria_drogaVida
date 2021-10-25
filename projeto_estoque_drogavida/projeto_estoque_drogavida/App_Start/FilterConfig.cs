using System.Web;
using System.Web.Mvc;

namespace projeto_estoque_drogavida
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
