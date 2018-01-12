using System.Web;
using System.Web.Mvc;

namespace XP.Web.TesteBuild.Teste
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
