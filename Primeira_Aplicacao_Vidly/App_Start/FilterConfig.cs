using System.Web;
using System.Web.Mvc;

namespace Primeira_Aplicacao_Vidly
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
