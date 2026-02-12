using System.Web;
using System.Web.Mvc;

namespace ESerranoMVC_EF_Yakuza
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
